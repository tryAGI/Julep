
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsBaseCloudinaryIntegrationDefUpdateMethod
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
    public static class ToolsBaseCloudinaryIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseCloudinaryIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBaseCloudinaryIntegrationDefUpdateMethod.MediaEdit => "media_edit",
                ToolsBaseCloudinaryIntegrationDefUpdateMethod.MediaUpload => "media_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseCloudinaryIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "media_edit" => ToolsBaseCloudinaryIntegrationDefUpdateMethod.MediaEdit,
                "media_upload" => ToolsBaseCloudinaryIntegrationDefUpdateMethod.MediaUpload,
                _ => null,
            };
        }
    }
}