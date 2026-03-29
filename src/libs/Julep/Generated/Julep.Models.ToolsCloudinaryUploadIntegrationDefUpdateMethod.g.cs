
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: media_upload
    /// </summary>
    public enum ToolsCloudinaryUploadIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        MediaUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsCloudinaryUploadIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsCloudinaryUploadIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsCloudinaryUploadIntegrationDefUpdateMethod.MediaUpload => "media_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsCloudinaryUploadIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "media_upload" => ToolsCloudinaryUploadIntegrationDefUpdateMethod.MediaUpload,
                _ => null,
            };
        }
    }
}