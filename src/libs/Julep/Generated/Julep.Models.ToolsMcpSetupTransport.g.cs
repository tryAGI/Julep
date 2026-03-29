
#nullable enable

namespace Julep
{
    /// <summary>
    /// Transport used to connect to the MCP server
    /// </summary>
    public enum ToolsMcpSetupTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsMcpSetupTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMcpSetupTransport value)
        {
            return value switch
            {
                ToolsMcpSetupTransport.Http => "http",
                ToolsMcpSetupTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMcpSetupTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => ToolsMcpSetupTransport.Http,
                "sse" => ToolsMcpSetupTransport.Sse,
                _ => null,
            };
        }
    }
}