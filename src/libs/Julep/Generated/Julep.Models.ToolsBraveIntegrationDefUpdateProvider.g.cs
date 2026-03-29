
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "brave"<br/>
    /// Default Value: brave
    /// </summary>
    public enum ToolsBraveIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Brave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBraveIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBraveIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsBraveIntegrationDefUpdateProvider.Brave => "brave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBraveIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "brave" => ToolsBraveIntegrationDefUpdateProvider.Brave,
                _ => null,
            };
        }
    }
}