using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Api.Version1.Actions
{
    public static class ModuleOptions
    {
        // Options
        public const string IdentityServerHost = "http://localhost:5000/";
        public const string ApiClientId = "Security.Api.Version1";
        public const string ApiUrl = "http://localhost:9011"; // should be the same like launchsettings.json
    }
}
