using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automation.Core.Web
{
    public static class AppSettings
    {
        public const string ConnectionStringsDefault = "ConnectionStrings:Default";
        public const string ExtensionsPath = "Extensions:Path";
        public const string LoggingPathFormat = "Logging:PathFormat";
        public const string JwtKey = "Jwt:Key";
        public const string JwtIssuer = "Jwt:Issuer";
    }
}
