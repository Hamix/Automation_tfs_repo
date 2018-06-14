using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class User : IEntity, IUniqueEntity, IAuditableEntity, IUndeletableEntity, IDocumentEntity, ISystemEntity,
        IDescriptiveEntity,ISQLAuditableEntity
    {
        /// <summary>
        /// data type: [int] not null
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// data type: [varchar] (20) not null
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// data type: [nvarchar] (50) not null
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// data type: [varchar] (254) not null
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// data type: [varchar] (200) not null
        /// </summary>
        public string HashedPassword { get; set; }
        /// <summary>
        /// data type: [varchar] (200) not null
        /// </summary>
        public string Salt { get; set; }
        /// <summary>
        /// data type: [bit] not null
        /// </summary>
        public bool IsLocked { get; set; }
        /// <summary>
        /// data type: [bit] not null
        /// </summary>
        public bool EmailConfirmed { get; set; }
        /// <summary>
        /// data type: [varchar] (15) not null
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// data type: [bit] not null
        /// </summary>
        public bool PhoneNumberConfirmed { get; set; }
        /// <summary>
        /// data type: [tinyint] NOT NULL
        /// </summary>
        public byte AccessFailedCount { get; set; }
        /// <summary>
        /// data type: [bit] NOT NULL
        /// </summary>
        public bool TwoFactorEnabled { get; set; }
        /// <summary>
        /// data type: [bit] NOT NULL
        /// </summary>
        public bool IsSystemEntity { get; set; }
        /// <summary>
        /// data type: [nvarchar] (100) Nullable
        /// </summary>
        public string Description { get; set; }

        #region Auditable Entity

        /// <summary>
        /// data type: [int] NOT NULL
        /// </summary>
        public int? ModifierUserID { get; set; }
        /// <summary>
        /// data type: [int] NOT NULL
        /// </summary>
        public int? ModifierPredicateID { get; set; }
        /// <summary>
        /// data type: [int] NOT NULL
        /// </summary>
        public int? ModifierSessionID { get; set; }
        /// <summary>
        /// data type: [bit] NOT NULL
        /// </summary>
        public bool IsDeleted { get; set; }

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
        
        #region Relations

        public ICollection<PredicateUser> PredicatesUsers { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<AuthenticateLog> AuthenticateLogs { get; set; }

        #endregion

    }
}
