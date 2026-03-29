
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "mailgun"<br/>
    /// Default Value: mailgun
    /// </summary>
    public enum ToolsMailgunIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Mailgun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsMailgunIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMailgunIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsMailgunIntegrationDefProvider.Mailgun => "mailgun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMailgunIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "mailgun" => ToolsMailgunIntegrationDefProvider.Mailgun,
                _ => null,
            };
        }
    }
}