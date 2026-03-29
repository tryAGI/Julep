
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: remote_browser
    /// </summary>
    public enum ToolsRemoteBrowserIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        RemoteBrowser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsRemoteBrowserIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsRemoteBrowserIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsRemoteBrowserIntegrationDefUpdateProvider.RemoteBrowser => "remote_browser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsRemoteBrowserIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "remote_browser" => ToolsRemoteBrowserIntegrationDefUpdateProvider.RemoteBrowser,
                _ => null,
            };
        }
    }
}