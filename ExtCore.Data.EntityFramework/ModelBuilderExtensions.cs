using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ExtCore.Data.EntityFramework
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>( this ModelBuilder modelBuilder, 
            EntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }
}
