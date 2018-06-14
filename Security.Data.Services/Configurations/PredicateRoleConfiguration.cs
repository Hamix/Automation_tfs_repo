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
    public class PredicateRoleConfiguration : EntityConfiguration<PredicateRole>
    {
        public override void Configure(EntityTypeBuilder<PredicateRole> builder)
        {
            builder.ToTable(SecurityTableNames.SecurityPredicateRole);

            builder.HasKey(pu => new { pu.PredicateID, pu.RoleID });

            #region Relations

            //Role
            builder.HasOne(pr => pr.Role)
                .WithMany(r => r.PredicateRoles)
                .HasForeignKey(pr => pr.RoleID);

            //Predicate
            builder.HasOne(pr => pr.Predicate)
                .WithMany(r => r.PredicateRoles)
                .HasForeignKey(pr => pr.PredicateID);

            #endregion
        }
    }
}
