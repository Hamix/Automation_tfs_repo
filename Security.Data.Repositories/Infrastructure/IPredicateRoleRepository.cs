using System.Collections.Generic;
using System.Linq;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IPredicateRoleRepository : IRepository
    {
        PredicateRole Get(int predicateId, int roleId);
        IQueryable GetByPredicateId(int predicateId);
        IQueryable GetByRoleId(int roleId);
        IEnumerable<PredicateRole> All();
        void Create(PredicateRole entity);
        void Edit(PredicateRole entity);
        void Delete(int id);
        void Delete(PredicateRole entity);
        decimal Total();
    }
}