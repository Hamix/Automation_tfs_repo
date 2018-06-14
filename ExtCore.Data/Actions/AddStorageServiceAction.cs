﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ExtCore.Data.Actions
{
    public class AddStorageServiceAction : IConfigureServicesAction
    {
        /// <summary>
        /// Priority of the action. The actions will be executed in the order specified by the priority (from smallest to largest).
        /// </summary>
        public int Priority => 1000;

        /// <summary>
        /// Registers found implementation of the <see cref="IStorageService">IStorageService</see> interface inside the DI.
        /// </summary>
        /// <param name="serviceCollection">
        /// Will be provided by the ExtCore and might be used to register any service inside the DI.
        /// </param>
        /// <param name="serviceProvider">
        /// Will be provided by the ExtCore and might be used to get any service that is registered inside the DI at this moment.
        /// </param>
        public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
        {
            Type type = ExtensionManager.GetImplementations<IStorageService>()
                ?.FirstOrDefault(t => !t.GetTypeInfo().IsAbstract);

            if (type == null)
            {
                ILogger logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger("ExtCore.Data");

                logger.LogError("Implementation of ExtCore.Data.Abstractions.IStorageService not found");
                return;
            }

            services.AddScoped(typeof(IStorageService), type);
        }
    }
}