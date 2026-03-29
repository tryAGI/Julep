
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: create_session
    /// </summary>
    public enum ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CreateSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod.CreateSession => "create_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "create_session" => ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod.CreateSession,
                _ => null,
            };
        }
    }
}