
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: media_edit
    /// </summary>
    public enum ToolsCloudinaryEditIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        MediaEdit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsCloudinaryEditIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsCloudinaryEditIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsCloudinaryEditIntegrationDefMethod.MediaEdit => "media_edit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsCloudinaryEditIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "media_edit" => ToolsCloudinaryEditIntegrationDefMethod.MediaEdit,
                _ => null,
            };
        }
    }
}