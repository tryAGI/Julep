
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: get_session
    /// </summary>
    public enum ToolsBrowserbaseGetSessionIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        GetSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseGetSessionIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseGetSessionIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseGetSessionIntegrationDefMethod.GetSession => "get_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseGetSessionIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "get_session" => ToolsBrowserbaseGetSessionIntegrationDefMethod.GetSession,
                _ => null,
            };
        }
    }
}