
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "email"<br/>
    /// Default Value: email
    /// </summary>
    public enum ToolsEmailIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsEmailIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsEmailIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsEmailIntegrationDefProvider.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsEmailIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "email" => ToolsEmailIntegrationDefProvider.Email,
                _ => null,
            };
        }
    }
}