
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsBrowserbaseExtensionIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        InstallExtensionFromGithub,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseExtensionIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseExtensionIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseExtensionIntegrationDefUpdateMethod.InstallExtensionFromGithub => "install_extension_from_github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseExtensionIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "install_extension_from_github" => ToolsBrowserbaseExtensionIntegrationDefUpdateMethod.InstallExtensionFromGithub,
                _ => null,
            };
        }
    }
}