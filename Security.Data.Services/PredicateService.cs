using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using ExtCore.Data.EntityFramework;
using Security.Data.Entities;
using Security.Data.Services.Infrastructure;

namespace Security.Data.Services
{
    public class PredicateService : RepositoryServiceBase, IPredicateService
    {
        public PredicateService(IStorage storage) : base(storage)
        {
        }

        public Predicate GetPredicate(int predicateId, bool active)
        {
            throw new NotImplementedException();
        }
    }
}
