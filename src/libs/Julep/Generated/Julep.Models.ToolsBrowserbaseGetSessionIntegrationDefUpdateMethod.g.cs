
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: get_session
    /// </summary>
    public enum ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        GetSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseGetSessionIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod.GetSession => "get_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "get_session" => ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod.GetSession,
                _ => null,
            };
        }
    }
}