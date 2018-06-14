using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Entities.Abstractions
{
    public interface IUndeletableEntity
    {
        bool IsDeleted { get; set; }
    }
}
