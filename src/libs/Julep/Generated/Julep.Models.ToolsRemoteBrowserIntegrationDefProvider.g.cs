
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: remote_browser
    /// </summary>
    public enum ToolsRemoteBrowserIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        RemoteBrowser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsRemoteBrowserIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsRemoteBrowserIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsRemoteBrowserIntegrationDefProvider.RemoteBrowser => "remote_browser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsRemoteBrowserIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "remote_browser" => ToolsRemoteBrowserIntegrationDefProvider.RemoteBrowser,
                _ => null,
            };
        }
    }
}