using System;
using ExtCore.Data.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExtCore.Data.EntityFramework
{
    public abstract class EntityBaseConfiguration<T>: EntityConfiguration<T> where T: class, IUniqueEntity 
    {
        public EntityTypeBuilder<T> Builder { get; set; }
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.ID);
            Builder = builder;
        }
    }
}
