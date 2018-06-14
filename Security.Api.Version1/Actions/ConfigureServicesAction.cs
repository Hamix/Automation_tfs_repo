using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Security.Api.Version1.Actions
{
    /*public class ConfigureServicesAction: IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            // This is a bad (but quick) way to provide configurations to the extensions. A good one is to use the options pattern.
            /*IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(serviceProvider.GetService<IHostingEnvironment>().ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(configurationBuilder.Build().GetConnectionString("Default")));#1#

            /*serviceCollection.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();#1#

            //serviceCollection.AddScoped(typeof(IStorageContext), typeof(ApplicationDbContext));
        }
    }*/
}
