using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class Session:IEntity, IUniqueEntity,IUndeletableEntity, ISystemEntity,IAuditableEntity,ISQLAuditableEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string IPAddress { get; set; }
        public string CredentialKey { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSystemEntity { get; set; }
        public bool IsTerminated { get; set; }

        #region Relations

        public ICollection<User> Users { get; set; }

        #endregion

        #region Auditable Entity

        public int? ModifierUserID { get; set; }
        public int? ModifierPredicateID { get; set; }
        public int? ModifierSessionID { get; set; }

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
