using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Abstractions
{
    public interface IStorageService
    {
        IStorage Storage { get; }

        T GetRepositoryService<T>() where T : IRepositoryService;

        /// <summary>
        /// Commits the changes made by all the repositories.
        /// </summary>
        void Save();
    }
}
