using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IPermissionRepository:IRepository
    {
        Permission Get(int id);
        IEnumerable<Permission> All();
        void Create(Permission entity);
        void Edit(Permission entity);
        void Delete(int id);
        void Delete(Permission entity);
        decimal Total();
    }
}
