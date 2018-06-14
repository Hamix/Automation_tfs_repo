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
    public class PredicateConfiguration:EntityConfiguration<Predicate>
    {
        public override void Configure(EntityTypeBuilder<Predicate> builder)
        {
            builder.ToTable(SecurityTableNames.SecurityPredicate);

            builder.HasKey(p => p.ID);

            #region Name Mapping

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(p => p.LocalizedName).IsRequired().HasMaxLength(50).IsUnicode();

            #endregion

            #region General Mapping

            builder.Property(p => p.IsSystemEntity).IsRequired();
            builder.Property(p => p.Description).IsRequired(false).HasMaxLength(100).IsUnicode();
            builder.Property(p => p.IsDeleted).IsRequired();

            #endregion


        }
    }
}
