using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExtCore.Data.EntityFramework
{
    public abstract class EntityConfiguration<T> where T:class
    {
        public abstract void Configure(EntityTypeBuilder<T> builder);
    }
}
