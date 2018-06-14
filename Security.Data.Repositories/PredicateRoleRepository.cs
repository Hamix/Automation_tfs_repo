using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtCore.Data.EntityFramework;
using Security.Data.Entities;
using Security.Data.Repositories.Infrastructure;

namespace Security.Data.Repositories
{
    public class PredicateRoleRepository : RepositoryBase<PredicateRole>, IPredicateRoleRepository
    {
        public PredicateRole Get(int predicateId, int roleId)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetByPredicateId(int predicateId)
        {
            return DbSet.Where(pr => pr.PredicateID == predicateId);
        }

        public IQueryable GetByRoleId(int roleId)
        {
            return DbSet.Where(pr => pr.PredicateID == roleId);
        }

        public IEnumerable<PredicateRole> All()
        {
            throw new NotImplementedException();
        }

        public void Create(PredicateRole entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(PredicateRole entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(PredicateRole entity)
        {
            throw new NotImplementedException();
        }

        public decimal Total()
        {
            throw new NotImplementedException();
        }
    }
}
