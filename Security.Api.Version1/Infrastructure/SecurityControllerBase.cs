using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ExtCore.Data.Abstractions;

namespace Security.Api.Version1.Infrastructure
{
    public class SecurityControllerBase : Controller
    {
        protected IStorageService StorageService { get; private set; }

        protected SecurityControllerBase(IStorageService storageService)
        {

            StorageService = storageService;
        }
    }
}
