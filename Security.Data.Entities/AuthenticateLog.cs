using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class AuthenticateLog : IEntity, IUniqueEntity,IUndeletableEntity,ISQLAuditableEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public byte AttemptType { get; set; }
        public byte AuthenticateResultTypeID { get; set; }
        public string IP { get; set; }
        public bool IsDeleted { get; set; }

        #region Relations

        public AuthenticateResultType AuthenticateResultType { get; set; }

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
