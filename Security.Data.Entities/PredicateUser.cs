using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class PredicateUser  : IEntity, IUndeletableEntity, IAuditableEntity, ISystemEntity,ISQLAuditableEntity
    {
        public int UserID { get; set; }
        public int PredicateID { get; set; }

        public bool IsActive { get; set; }

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
        //EF core doesn't support many to many
        public  Predicate Predicate { get; set; }

        public User User { get; set; }
        #endregion
    }
}
