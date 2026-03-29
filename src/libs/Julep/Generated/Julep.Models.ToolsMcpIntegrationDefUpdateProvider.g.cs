
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "mcp"<br/>
    /// Default Value: mcp
    /// </summary>
    public enum ToolsMcpIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsMcpIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMcpIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsMcpIntegrationDefUpdateProvider.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMcpIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ToolsMcpIntegrationDefUpdateProvider.Mcp,
                _ => null,
            };
        }
    }
}