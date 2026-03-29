
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: cloudinary
    /// </summary>
    public enum ToolsBaseCloudinaryIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cloudinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseCloudinaryIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseCloudinaryIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsBaseCloudinaryIntegrationDefProvider.Cloudinary => "cloudinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseCloudinaryIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "cloudinary" => ToolsBaseCloudinaryIntegrationDefProvider.Cloudinary,
                _ => null,
            };
        }
    }
}