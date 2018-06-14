using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Repositories.Infrastructure
{
    public interface IOrganizationChartRepository: IRepository
    {
        OrganizationChart Get(int id);
        IEnumerable<OrganizationChart> All();
        void Create(OrganizationChart entity);
        void Edit(OrganizationChart entity);
        void Delete(int id);
        void Delete(OrganizationChart entity);
        decimal Total();

    }
}
