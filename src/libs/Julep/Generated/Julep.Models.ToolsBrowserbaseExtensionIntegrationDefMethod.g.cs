
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsBrowserbaseExtensionIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        InstallExtensionFromGithub,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseExtensionIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseExtensionIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseExtensionIntegrationDefMethod.InstallExtensionFromGithub => "install_extension_from_github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseExtensionIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "install_extension_from_github" => ToolsBrowserbaseExtensionIntegrationDefMethod.InstallExtensionFromGithub,
                _ => null,
            };
        }
    }
}