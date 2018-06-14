using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ExtCore.Data.EntityFramework
{
    public abstract class RepositoryServiceBase:IRepositoryService
    {
        public RepositoryServiceBase(IStorage storage)
        {
            Storage = storage;
        }
        public IStorage Storage { get; private set; }

        public void SetStorage(IStorage storage)
        {
            //Storage = storage;
        }

    }
}
