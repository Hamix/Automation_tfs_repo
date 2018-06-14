using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class Document : IEntity,IUniqueEntity, INamedEntity, IDescriptiveEntity, IAuditableEntity, IUndeletableEntity,
        ISystemEntity,ISQLAuditableEntity
    {
        public int ID { get; set; }

        public string TableName { get; set; }

        public int DocumentTypeID { get; set; }
        public string Name { get; set; }
        public string LocalizedName { get; set; }
        public string Description { get; set; }
        public bool Attachable { get; set; }
        public bool Referable { get; set; }
        public bool Modifiable { get; set; }
        public bool Reversionable { get; set; }
        public byte  PrivacyLevel { get; set; }


        #region Auditable Entity

        public int? ModifierUserID { get; set; }
        public int? ModifierPredicateID { get; set; }
        public int? ModifierSessionID { get; set; }
        public bool IsDeleted { get; set; }

        #endregion

        public bool IsSystemEntity { get; set; }

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

        #region Relations

        public DocumentType DocumentType { get; set; }
        //public DocumentRelationType DocumentRelationType { get; set; }

        #endregion
    }
}
