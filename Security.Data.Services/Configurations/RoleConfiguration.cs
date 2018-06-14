using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Data.Entities;
using Security.Data.ObjectNames;

namespace Security.Data.Services.Configurations
{
    public class RoleConfiguration : EntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(SecurityTableNames.SecurityRole);

            builder.HasKey(u => u.ID);

            #region Name Mapping

            builder.Property(r => r.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(r => r.LocalizedName).IsRequired().HasMaxLength(50).IsUnicode();

            #endregion

            #region General Mapping

            builder.Property(r => r.IsSystemEntity).IsRequired();
            builder.Property(r => r.Description).IsRequired(false).HasMaxLength(100).IsUnicode();
            builder.Property(r => r.IsDeleted).IsRequired();

            #endregion

        }
    }
}
