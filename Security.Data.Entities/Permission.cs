using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class Permission:IEntity,INamedEntity, IUniqueEntity, IUndeletableEntity, IAuditableEntity, ISystemEntity,ISQLAuditableEntity
    {
        public int ID { get; set; }

        public  string Name { get; set; }
        public string LocalizedName { get; set; }

        #region Auditable Entity

        public int? ModifierUserID { get; set; }
        public int? ModifierPredicateID { get; set; }
        public int? ModifierSessionID { get; set; }
        public bool IsDeleted { get; set; }

        #endregion

        public bool IsSystemEntity { get; set; }

        #region Relations

        public ICollection<Role> Roles { get; set; }

        #endregion

        #region SQL Auditable Entity

        public string SQLUser { get; set; }
        public string SQLHostName { get; set; }
        public string SQLNetTransport { get; set; }
        public string SQLProtocolType { get; set; }
        public string SQLAuthScheme { get; set; }
        public string SQLLocalNetAddress { get; set; }
        public string SQLLocalTcpPort { get; set; }
        public string SQLClientNetAddress { get; set; }
        public string SQLPhysicalNetTransport { get; set; }

        #endregion
    }
}
