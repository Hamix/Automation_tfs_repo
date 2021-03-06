﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Core.Web.Infrastructure;
using ExtCore.Data.EntityFramework;
using ExtCore.WebApplication.Extensions;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Automation.Core.Web
{
    public class Startup
    {
        private readonly IConfigurationRoot _configurationRoot;
        private readonly string _extensionsPath;

        public Startup(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            this._configurationRoot = configurationBuilder.Build();
            this._extensionsPath = hostingEnvironment.ContentRootPath + this._configurationRoot[AppSettings.ExtensionsPath];
            loggerFactory.AddConsole(_configurationRoot.GetSection("Logging"));
            loggerFactory.AddDebug(LogLevel.Warning);
            loggerFactory.AddFile(_configurationRoot.GetSection("Logging"));
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddExtCore(this._extensionsPath);

            services.Configure<StorageContextOptions>(options =>
                {
                    options.ConnectionString = this._configurationRoot.GetConnectionString("Default");
                }
            );

            // configure identity server with in-memory stores, keys, clients and scopes
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(IdentityConfig.GetIdentityResources());
                //.AddInMemoryApiResources(IdentityConfig.GetApiResources())
                //.AddInMemoryClients(IdentityConfig.GetClients())
                //.AddTestUsers(IdentityConfig.GetUsers());

            services.AddAuthentication()
                .AddGoogle("Google", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = "434483408261-55tc8n0cs4ff1fe21ea8df2o443v2iuc.apps.googleusercontent.com";
                    options.ClientSecret = "3gcoTrEDPPJ0ukn_aYYT6PWo";
                })
                .AddOpenIdConnect("oidc", "OpenID Connect", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                    options.SignOutScheme = IdentityServerConstants.SignoutScheme;

                    options.Authority = "https://demo.identityserver.io/";
                    options.ClientId = "implicit";

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = "name",
                        RoleClaimType = "role"
                    };
                });


        }

        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory)
        {
            if (hostingEnvironment.IsDevelopment())
            {
                applicationBuilder.UseDeveloperExceptionPage();
                applicationBuilder.UseDatabaseErrorPage();
                applicationBuilder.UseBrowserLink();
            }

            applicationBuilder.UseIdentityServer();
            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseExtCore();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /*public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }*/
    }
}
