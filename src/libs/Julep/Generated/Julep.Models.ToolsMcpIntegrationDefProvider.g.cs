
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "mcp"<br/>
    /// Default Value: mcp
    /// </summary>
    public enum ToolsMcpIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsMcpIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMcpIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsMcpIntegrationDefProvider.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMcpIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ToolsMcpIntegrationDefProvider.Mcp,
                _ => null,
            };
        }
    }
}