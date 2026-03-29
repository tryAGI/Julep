
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "brave"<br/>
    /// Default Value: brave
    /// </summary>
    public enum ToolsBraveIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Brave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBraveIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBraveIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsBraveIntegrationDefProvider.Brave => "brave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBraveIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "brave" => ToolsBraveIntegrationDefProvider.Brave,
                _ => null,
            };
        }
    }
}