using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class OrganizationChart:IEntity,IUniqueEntity, INamedEntity, IUndeletableEntity, IAuditableEntity, ISystemEntity,ISQLAuditableEntity,IDescriptiveEntity
    {
        public int ID { get; set; }

        public int ParentID { get; set; }
        public string Name { get; set; }
        public string LocalizedName { get; set; }
        public int OrganizationNodeTypeID { get; set; }


        #region Auditable Entity

        public int? ModifierUserID { get; set; }
        public int? ModifierPredicateID { get; set; }
        public int? ModifierSessionID { get; set; }
        public bool IsDeleted { get; set; }

        #endregion

        public bool IsSystemEntity { get; set; }

        #region Relations

        public OrganizationChart Parent { get; set; }
        public ICollection<OrganizationChart> Childern { get; set; }
        public OrganizationNodeType OrganizationNodeType { get; set; }

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

        public string Description { get; set; }
    }
}
