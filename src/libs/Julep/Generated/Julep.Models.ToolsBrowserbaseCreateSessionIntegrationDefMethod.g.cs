
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: create_session
    /// </summary>
    public enum ToolsBrowserbaseCreateSessionIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CreateSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseCreateSessionIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseCreateSessionIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseCreateSessionIntegrationDefMethod.CreateSession => "create_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseCreateSessionIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "create_session" => ToolsBrowserbaseCreateSessionIntegrationDefMethod.CreateSession,
                _ => null,
            };
        }
    }
}