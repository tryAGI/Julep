
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: complete_session
    /// </summary>
    public enum ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CompleteSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod.CompleteSession => "complete_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "complete_session" => ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod.CompleteSession,
                _ => null,
            };
        }
    }
}