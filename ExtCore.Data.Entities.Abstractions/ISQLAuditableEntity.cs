using System;
using System.Collections.Generic;
using System.Text;

namespace ExtCore.Data.Entities.Abstractions
{
    public interface ISQLAuditableEntity
    {
        string SQLUser { get; }
        string SQLHostName { get;}
        string SQLNetTransport { get;}
        string SQLProtocolType { get; }
        string SQLAuthScheme { get;}
        string SQLLocalNetAddress { get;}
        string SQLLocalTcpPort { get; }
        string SQLClientNetAddress { get;}
        string SQLPhysicalNetTransport { get; }
    }
}
