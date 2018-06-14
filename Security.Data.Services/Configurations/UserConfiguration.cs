using System;
using System.Collections.Generic;
using System.Text;
using  ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Security.Data.Entities;
using Security.Data.ObjectNames;

namespace Security.Data.Services.Configurations
{
    public class UserConfiguration : EntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(SecurityTableNames.SecurityUser);

            builder.HasKey(u => u.ID);
            builder.Property(u => u.Username).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(u => u.FullName).IsRequired().HasMaxLength(50).IsUnicode();
            builder.Property(u => u.Email).IsRequired().HasMaxLength(254).IsUnicode(false);
            builder.Property(u => u.HashedPassword).IsRequired().HasMaxLength(200).IsUnicode(false);
            builder.Property(u => u.Salt).IsRequired().HasMaxLength(200).IsUnicode(false);
            builder.Property(u => u.IsLocked).IsRequired();
            builder.Property(u => u.EmailConfirmed).IsRequired();
            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(15).IsUnicode(false);
            builder.Property(u => u.PhoneNumberConfirmed).IsRequired();
            builder.Property(u => u.AccessFailedCount).IsRequired();
            builder.Property(u => u.TwoFactorEnabled).IsRequired();

            #region General Mapping

            builder.Property(u => u.IsSystemEntity).IsRequired();
            builder.Property(u => u.Description).IsRequired(false).HasMaxLength(100).IsUnicode();
            builder.Property(u => u.IsDeleted).IsRequired();

            #endregion

            #region  Relation Mappings

            /*builder.HasMany(u => u.PredicatesUsers)
                .WithOne(pu => pu.User)
                .HasForeignKey(c => c.UserID);*/

            #endregion
        }
    }
}
