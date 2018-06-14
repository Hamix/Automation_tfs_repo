using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using ExtCore.Data.Abstractions;
using ExtCore.Data.EntityFramework;
using Security.Data.Entities;
using Security.Data.Repositories;
using Security.Data.Repositories.Infrastructure;
using Security.Data.Services.Infrastructure;
using Security.Encryption;

namespace Security.Data.Services
{
    public class MembershipService : RepositoryServiceBase, IMembershipService
    {
        #region Variables

        private readonly IUserRepository _userRepository;
        private readonly IPredicateRepository _predicateRepository;
        private readonly IPredicateUserRepository _predicateUserRepository;
        private readonly IPredicateRoleRepository _predicateRoleRepository;
        private readonly IEncryptionService _encryptionService;

        #endregion

        public MembershipService(IStorage storage) : base(storage)
        {
            _userRepository = Storage.GetRepository<IUserRepository>();
            _predicateRepository = Storage.GetRepository<IPredicateRepository>();
            _predicateUserRepository = Storage.GetRepository<IPredicateUserRepository>();
            _predicateRoleRepository = Storage.GetRepository<IPredicateRoleRepository>();
            _encryptionService = new EncryptionService();
        }

        public MembershipContext ValidateUser(string username, string password)
        {
            var membershipCtx = new MembershipContext();

            var user = _userRepository.GetByUsername(username, includePredicates: true);
            if (user != null && IsUserValid(user, password))
            {
                var userRoles = GetUserRoles(user);
                membershipCtx.User = user;

                var identity = new GenericIdentity(user.Username);
                membershipCtx.Principal = new GenericPrincipal(
                    identity,
                    userRoles.Select(x => x.Name).ToArray());

            }
            return membershipCtx;
        }

        public User CreateUser(string username, string email, string password, string fullname, string phoneNumber,
            int? predicateId)
        {
            var existingUser = _userRepository.GetByUsername(username);
            if (existingUser != null)
            {
                throw new Exception("Username is already in use");
            }

            existingUser = _userRepository.GetByEmail(email);
            if (existingUser != null)
            {
                throw new Exception("Email is already in use");
            }

            var passwordSalt = _encryptionService.CreateSalt();
            var hashedPassword = _encryptionService.EncryptPassword(password, passwordSalt);

            var user = new User()
            {
                Username = username,
                Salt = passwordSalt,
                Email = email,
                IsLocked = false,
                FullName = fullname,
                AccessFailedCount = 0,
                PhoneNumber = phoneNumber,
                EmailConfirmed = false,
                IsSystemEntity = false,
                IsDeleted = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                HashedPassword = hashedPassword
            };
            _userRepository.Create(user);
            if (predicateId.HasValue && predicateId != 0)
            {
                AssignPredicateToUser(user, predicateId.Value);
            }

            return user;
        }

        public User GetUser(int id)
        {
            return _userRepository.Get(id);
        }

        public List<Role> GetUserRoles(string username)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetUserRoles(User user)
        {
            var userPredicate = user.PredicatesUsers.FirstOrDefault(pu => pu.IsActive);
            if (userPredicate == null)
                throw new Exception("There is no active Predicate.");

            var roles = userPredicate.Predicate.PredicateRoles.Select(pr => pr.Role);

            return roles;
        }

        private void AssignPredicateToUser(User user, int predicateId)
        {
            var predicate = _predicateRepository.Get(predicateId);
            if (predicate == null)
                throw new ApplicationException("Predicate doesn't exist.");
            var predicateUser = new PredicateUser()
            {
                PredicateID = predicateId,
                UserID = user.ID,
                IsActive = true,
                IsDeleted = false,
                IsSystemEntity = false
            };
            _predicateUserRepository.Create(predicateUser);
        }

        private bool IsUserValid(User user, string password)
        {
            if (IsPasswordValid(user, password))
            {
                return !user.IsLocked;
            }

            return false;
        }

        private bool IsPasswordValid(User user, string password)
        {
            return string.Equals(_encryptionService.EncryptPassword(password, user.Salt), user.HashedPassword);
        }
    }
}