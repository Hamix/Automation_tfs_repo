using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Security.Web.Api.Versoin1.Actions
{
    public static class ModuleOptions
    {
        // Options
        public const string IdentityServerHost = "http://localhost:5000/";
        public const string ApiClientId = "Security.Web.Api.Version1";
        public const string ApiUrl = "http://localhost:5001"; // should be the same like launchsettings.json
    }
}
