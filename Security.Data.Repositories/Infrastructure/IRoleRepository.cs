using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IRoleRepository:IRepository
    {
        Role Get(int id);
        IEnumerable<Role> All();
        void Create(Role entity);
        void Edit(Role entity);
        void Delete(int id);
        void Delete(Role entity);
        decimal Total();
    }
}
