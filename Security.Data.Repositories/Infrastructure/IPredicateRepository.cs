using System.Collections.Generic;
using System.Linq;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IPredicateRepository:IRepository
    {
        Predicate Get(int id);
        IEnumerable<Predicate> All();
        void Create(Predicate entity);
        void Edit(Predicate entity);
        void Delete(int id);
        void Delete(Predicate entity);
        decimal Total();

    }
}
