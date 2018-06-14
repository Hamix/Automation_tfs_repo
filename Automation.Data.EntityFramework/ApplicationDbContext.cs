using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Automation.Data.EntityFramework
{
    public class ApplicationDbContext: DbContext, IStorageContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.RegisterEntities(modelBuilder);
        }
    }
}
