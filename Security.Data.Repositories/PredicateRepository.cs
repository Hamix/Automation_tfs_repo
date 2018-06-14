using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtCore.Data.EntityFramework;
using Security.Data.Entities;
using Security.Data.Repositories.Infrastructure;

namespace Security.Data.Repositories
{
    public class PredicateRepository : RepositoryBase<Predicate>, IPredicateRepository
    {
        public Predicate Get(int id)
        {
            return DbSet.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<Predicate> All()
        {
            throw new NotImplementedException();
        }

        public void Create(Predicate entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Predicate entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Predicate entity)
        {
            throw new NotImplementedException();
        }

        public decimal Total()
        {
            throw new NotImplementedException();
        }
    }
}
