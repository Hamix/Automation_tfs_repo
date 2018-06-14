using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IUserRepository:IRepository
    {
        User Get(int id);
        User GetByUsername(string username, bool includePredicates = false);
        User GetByEmail(string email);
        User Get(string username, string email);
        IEnumerable<User> All();
        User Create(User entity);
        void Edit(User entity);
        void Delete(int id);
        void Delete(User entity);
        decimal Total();

        bool ValidateUser(string username, string password);
    }
}
