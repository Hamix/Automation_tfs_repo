using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtCore.Data.EntityFramework;
using Security.Data.Entities;
using Security.Data.Repositories.Infrastructure;

namespace Security.Data.Repositories
{
    public class PredicateUserRepository: RepositoryBase<PredicateUser>, IPredicateUserRepository
    {
        public PredicateUser Get(int predicateId, int userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetByPredicateId(int predicateId)
        {
            return DbSet.Where(pu => pu.PredicateID == predicateId);
        }

        public IQueryable GetByUserId(int userId)
        {
            return DbSet.Where(pu => pu.UserID == userId);
        }

        public IEnumerable<PredicateUser> All()
        {
            throw new NotImplementedException();
        }

        public PredicateUser Create(PredicateUser entity)
        {
            DbSet.Add(entity);
            StorageContext.SaveChanges();
            return entity; 
        }

        public void Edit(PredicateUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(PredicateUser entity)
        {
            throw new NotImplementedException();
        }

        public decimal Total()
        {
            throw new NotImplementedException();
        }
    }
}
