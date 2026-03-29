
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "email"<br/>
    /// Default Value: email
    /// </summary>
    public enum ToolsEmailIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsEmailIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsEmailIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsEmailIntegrationDefUpdateProvider.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsEmailIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "email" => ToolsEmailIntegrationDefUpdateProvider.Email,
                _ => null,
            };
        }
    }
}