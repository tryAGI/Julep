
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: media_edit
    /// </summary>
    public enum ToolsCloudinaryEditIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        MediaEdit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsCloudinaryEditIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsCloudinaryEditIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsCloudinaryEditIntegrationDefUpdateMethod.MediaEdit => "media_edit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsCloudinaryEditIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "media_edit" => ToolsCloudinaryEditIntegrationDefUpdateMethod.MediaEdit,
                _ => null,
            };
        }
    }
}