using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Security.Api.Version1.Infrastructure;
using Security.Data.Repositories;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Security.Data.Repositories.Infrastructure;
using Security.Data.Services.Infrastructure;

namespace Security.Api.Version1.Controllers
{
    [Route("api/v1")]
    
    public class UserController : SecurityControllerBase
    {
        #region Services

        private readonly IMembershipService _membershipService;

        #endregion

        public UserController(IStorageService storage) : base(storage)
        {
            _membershipService = StorageService.GetRepositoryService<IMembershipService>();
        }


        [HttpGet,Authorize]
        [Route("getUser")]
        public IEnumerable<string> Get()
        {
            var user = _membershipService.ValidateUser("SystemAdmin", "Admin$$1397 Ok@136");
            //_membershipService.CreateUser("SystemAdmin", "Hamzehomry@gmail.com", "Admin$$1397 Ok@136", "System Admin","09367405157", 3);
            //var s = StorageService.GetRepository<IUserRepository>();
            //StorageService.Save();
            return new[] {"item 1", "item 2"};
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("test")]
        public IEnumerable<string> G()
        {
            return new[] {"item 1", "item 2"};
        }
    }
}