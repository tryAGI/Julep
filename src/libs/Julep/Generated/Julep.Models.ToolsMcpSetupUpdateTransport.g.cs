
#nullable enable

namespace Julep
{
    /// <summary>
    /// Transport used to connect to the MCP server
    /// </summary>
    public enum ToolsMcpSetupUpdateTransport
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
    public static class ToolsMcpSetupUpdateTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMcpSetupUpdateTransport value)
        {
            return value switch
            {
                ToolsMcpSetupUpdateTransport.Http => "http",
                ToolsMcpSetupUpdateTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMcpSetupUpdateTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => ToolsMcpSetupUpdateTransport.Http,
                "sse" => ToolsMcpSetupUpdateTransport.Sse,
                _ => null,
            };
        }
    }
}