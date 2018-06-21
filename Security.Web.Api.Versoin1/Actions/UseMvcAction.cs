using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Security.Web.Api.Versoin1.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(name: "Default", template: "{controller}/{action}", defaults: new { controller = "Default", action = "Index" });
        }
    }
}
