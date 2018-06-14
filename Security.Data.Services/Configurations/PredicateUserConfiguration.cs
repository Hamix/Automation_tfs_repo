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
    public class PredicateUserConfiguration :EntityConfiguration<PredicateUser>
    {
        public override void Configure(EntityTypeBuilder<PredicateUser> builder)
        {
            builder.ToTable(SecurityTableNames.SecurityPredicateUser);

            builder.HasKey(pu => new {pu.PredicateID, pu.UserID});

            #region Relations

            //User
            builder.HasOne(pu => pu.User)
                .WithMany(u => u.PredicatesUsers)
                .HasForeignKey(pu => pu.UserID);

            //Predicate
            builder.HasOne(pu => pu.Predicate)
                .WithMany(u => u.PredicatesUsers)
                .HasForeignKey(pu => pu.PredicateID);

            #endregion

        }
    }
}
