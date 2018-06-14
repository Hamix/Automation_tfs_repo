using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Abstractions
{
    public interface IRepositoryService
    {
        void SetStorage(IStorage storage);
    }
}
