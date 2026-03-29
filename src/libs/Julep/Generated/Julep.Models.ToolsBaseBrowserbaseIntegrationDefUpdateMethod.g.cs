
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsBaseBrowserbaseIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CompleteSession,
        /// <summary>
        /// 
        /// </summary>
        CreateContext,
        /// <summary>
        /// 
        /// </summary>
        CreateSession,
        /// <summary>
        /// 
        /// </summary>
        GetConnectUrl,
        /// <summary>
        /// 
        /// </summary>
        GetLiveUrls,
        /// <summary>
        /// 
        /// </summary>
        GetLogs,
        /// <summary>
        /// 
        /// </summary>
        GetRecordings,
        /// <summary>
        /// 
        /// </summary>
        GetSession,
        /// <summary>
        /// 
        /// </summary>
        GetSessionDownloads,
        /// <summary>
        /// 
        /// </summary>
        InstallExtensionFromGithub,
        /// <summary>
        /// 
        /// </summary>
        ListSessions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseBrowserbaseIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseBrowserbaseIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.CompleteSession => "complete_session",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.CreateContext => "create_context",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.CreateSession => "create_session",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetConnectUrl => "get_connect_url",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetLiveUrls => "get_live_urls",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetLogs => "get_logs",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetRecordings => "get_recordings",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetSession => "get_session",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetSessionDownloads => "get_session_downloads",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.InstallExtensionFromGithub => "install_extension_from_github",
                ToolsBaseBrowserbaseIntegrationDefUpdateMethod.ListSessions => "list_sessions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseBrowserbaseIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "complete_session" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.CompleteSession,
                "create_context" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.CreateContext,
                "create_session" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.CreateSession,
                "get_connect_url" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetConnectUrl,
                "get_live_urls" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetLiveUrls,
                "get_logs" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetLogs,
                "get_recordings" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetRecordings,
                "get_session" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetSession,
                "get_session_downloads" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.GetSessionDownloads,
                "install_extension_from_github" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.InstallExtensionFromGithub,
                "list_sessions" => ToolsBaseBrowserbaseIntegrationDefUpdateMethod.ListSessions,
                _ => null,
            };
        }
    }
}