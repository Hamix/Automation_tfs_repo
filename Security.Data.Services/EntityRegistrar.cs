using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Security.Data.Entities;
using Security.Data.Services.Configurations;

namespace Security.Data.Services
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public DbSet<User> Users { get; set; }

        public void RegisterEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new UserConfiguration());
            modelBuilder.AddConfiguration(new RoleConfiguration());
            modelBuilder.AddConfiguration(new PredicateConfiguration());
            modelBuilder.AddConfiguration(new PredicateUserConfiguration());
            modelBuilder.AddConfiguration(new PredicateRoleConfiguration());

        }
    }
}
