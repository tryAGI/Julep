
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsBaseCloudinaryIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        MediaEdit,
        /// <summary>
        /// 
        /// </summary>
        MediaUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseCloudinaryIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseCloudinaryIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBaseCloudinaryIntegrationDefMethod.MediaEdit => "media_edit",
                ToolsBaseCloudinaryIntegrationDefMethod.MediaUpload => "media_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseCloudinaryIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "media_edit" => ToolsBaseCloudinaryIntegrationDefMethod.MediaEdit,
                "media_upload" => ToolsBaseCloudinaryIntegrationDefMethod.MediaUpload,
                _ => null,
            };
        }
    }
}