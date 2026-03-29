
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "mailgun"<br/>
    /// Default Value: mailgun
    /// </summary>
    public enum ToolsMailgunIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Mailgun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsMailgunIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMailgunIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsMailgunIntegrationDefUpdateProvider.Mailgun => "mailgun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMailgunIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "mailgun" => ToolsMailgunIntegrationDefUpdateProvider.Mailgun,
                _ => null,
            };
        }
    }
}