
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: cloudinary
    /// </summary>
    public enum ToolsBaseCloudinaryIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cloudinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseCloudinaryIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseCloudinaryIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsBaseCloudinaryIntegrationDefUpdateProvider.Cloudinary => "cloudinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseCloudinaryIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "cloudinary" => ToolsBaseCloudinaryIntegrationDefUpdateProvider.Cloudinary,
                _ => null,
            };
        }
    }
}