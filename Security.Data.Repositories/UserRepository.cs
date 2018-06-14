using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Security.Data.Entities;
using Security.Data.Repositories.Infrastructure;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Security.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User Get(int id)
        {
            return DbSet.FirstOrDefault(u => u.ID == id);
        }

        public User GetByUsername(string username, bool includePredicates=false)
        {
            if (includePredicates)
                return DbSet.Include(u => u.PredicatesUsers)
                    .ThenInclude(pu=>pu.Predicate)
                    .ThenInclude(p=>p.PredicateRoles)
                    .ThenInclude(pr => pr.Role)
                    .FirstOrDefault(u => u.Username.ToLower() == username);

            return DbSet.FirstOrDefault(u => u.Username.ToLower() == username);
        }

        public User GetByEmail(string email)
        {
            return DbSet.FirstOrDefault(u => u.Username.ToLower() == email);
        }

        public User Get(string username, string email)
        {
            return DbSet.FirstOrDefault(u => u.Username.ToLower() == username && u.Email.ToLower() == email);
        }

        public IEnumerable<User> All()
        {
            throw new NotImplementedException();
        }

        public User Create(User entity)
        {
            DbSet.Add(entity);
            StorageContext.SaveChanges();
            return entity;
        }

        public void Edit(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public decimal Total()
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(string username, string password)
        {

            throw new NotImplementedException();
        }
    }
}
