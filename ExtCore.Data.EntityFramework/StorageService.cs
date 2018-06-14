using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;

namespace ExtCore.Data.EntityFramework
{
    public class StorageService: IStorageService
    {
        public IStorage Storage { get; private set; }

        public StorageService(IStorage storage)
        {
            Storage = storage;
        }
        public T GetRepositoryService<T>() where T : IRepositoryService
        {
            T service = ExtensionManager.GetInstance<T>(null,false, Storage);

            //if (service != null)
                //service.SetStorage(Storage);

            return service;
        }

        public void Save()
        {
            Storage.Save();
        }
    }
}
