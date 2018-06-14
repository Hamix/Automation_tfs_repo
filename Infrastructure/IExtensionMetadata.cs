using System.Collections.Generic;

namespace Automation.Core.Infrastructure
{
    public interface IExtensionMetadata
    {
        IEnumerable<StyleSheet> StyleSheets { get; }
        IEnumerable<Script> Scripts { get; }
        IEnumerable<MenuItem> MenuItems { get; }
    }
}
