using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Services.Infrastructure
{
    public interface IPredicateService : IRepositoryService
    {
        Predicate GetPredicate(int predicateId, bool active);

    }
}
