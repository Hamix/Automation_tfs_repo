using System.Collections.Generic;
using System.Linq;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IPredicateUserRepository:IRepository
    {
        PredicateUser Get(int predicateId, int userId);

        IQueryable GetByPredicateId(int predicateId);
        IQueryable GetByUserId(int userId);
        IEnumerable<PredicateUser> All();
        PredicateUser Create(PredicateUser entity);
        void Edit(PredicateUser entity);
        void Delete(int id);
        void Delete(PredicateUser entity);
        decimal Total();
    }
}
