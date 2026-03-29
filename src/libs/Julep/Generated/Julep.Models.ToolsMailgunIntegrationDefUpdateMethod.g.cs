
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsMailgunIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        SendEmail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsMailgunIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsMailgunIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsMailgunIntegrationDefUpdateMethod.SendEmail => "send_email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsMailgunIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "send_email" => ToolsMailgunIntegrationDefUpdateMethod.SendEmail,
                _ => null,
            };
        }
    }
}