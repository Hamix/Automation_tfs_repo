using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IRolePermissionRepository:IRepository
    {
        RolePermission Get(int id);
        IEnumerable<RolePermission> All();
        void Create(RolePermission entity);
        void Edit(RolePermission entity);
        void Delete(int id);
        void Delete(RolePermission entity);
        decimal Total();
    }
}
