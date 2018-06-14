using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Entities.Abstractions
{
    public interface INamedEntity
    {
        string Name { get; set; }
        string LocalizedName { get; set; }
    }
}
