using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Security.Data.Entities;

namespace Security.Data.Services.Infrastructure
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
