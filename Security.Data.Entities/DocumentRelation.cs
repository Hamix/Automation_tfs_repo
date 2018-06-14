using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class DocumentRelation:IEntity,IUniqueEntity,IUndeletableEntity,IAuditableEntity,IDescriptiveEntity,ISQLAuditableEntity,ISystemEntity
    {
        public int ID { get; set; }

        public int MainDocumentID { get; set; }
        public string MainTableName { get; set; }
        public int AttachedDocumentID { get; set; }
        public string AttachedTableName { get; set; }
        public int DocumentRelationTypeID { get; set; }

        #region Auditable Entity

        public bool IsDeleted { get; set; }
        public int? ModifierUserID { get; set; }
        public int? ModifierPredicateID { get; set; }
        public int? ModifierSessionID { get; set; }

        #endregion

        public string Description { get; set; }

        #region Relations

        public DocumentRelationType DocumentRelationType { get; set; }

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

        public bool IsSystemEntity { get; set; }
    }
}
