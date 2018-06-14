using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Entities.Abstractions
{
    public interface IBaseInfo
    {
        /// <summary>
        /// All base infos must have a name(nvarchar 20)
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// All base infos may have a description(nvarchar 50)
        /// </summary>
        string Description { get; set; }
    }
}
