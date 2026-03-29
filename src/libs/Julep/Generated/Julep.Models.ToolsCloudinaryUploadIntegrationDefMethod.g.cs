
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: media_upload
    /// </summary>
    public enum ToolsCloudinaryUploadIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        MediaUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsCloudinaryUploadIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsCloudinaryUploadIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsCloudinaryUploadIntegrationDefMethod.MediaUpload => "media_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsCloudinaryUploadIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "media_upload" => ToolsCloudinaryUploadIntegrationDefMethod.MediaUpload,
                _ => null,
            };
        }
    }
}