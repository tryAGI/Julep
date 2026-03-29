
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call<br/>
    /// Default Value: list_sessions
    /// </summary>
    public enum ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        ListSessions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseListSessionsIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod.ListSessions => "list_sessions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "list_sessions" => ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod.ListSessions,
                _ => null,
            };
        }
    }
}