using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Entities.Abstractions
{
    public interface IDescriptiveEntity
    {
        /// <summary>
        /// Entity has description
        /// </summary>
        string Description { get; set; }
    }
}
