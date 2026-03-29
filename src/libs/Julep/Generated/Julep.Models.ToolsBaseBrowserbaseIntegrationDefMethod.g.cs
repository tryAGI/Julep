
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsBaseBrowserbaseIntegrationDefMethod
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
    public static class ToolsBaseBrowserbaseIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseBrowserbaseIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBaseBrowserbaseIntegrationDefMethod.CompleteSession => "complete_session",
                ToolsBaseBrowserbaseIntegrationDefMethod.CreateContext => "create_context",
                ToolsBaseBrowserbaseIntegrationDefMethod.CreateSession => "create_session",
                ToolsBaseBrowserbaseIntegrationDefMethod.GetConnectUrl => "get_connect_url",
                ToolsBaseBrowserbaseIntegrationDefMethod.GetLiveUrls => "get_live_urls",
                ToolsBaseBrowserbaseIntegrationDefMethod.GetLogs => "get_logs",
                ToolsBaseBrowserbaseIntegrationDefMethod.GetRecordings => "get_recordings",
                ToolsBaseBrowserbaseIntegrationDefMethod.GetSession => "get_session",
                ToolsBaseBrowserbaseIntegrationDefMethod.GetSessionDownloads => "get_session_downloads",
                ToolsBaseBrowserbaseIntegrationDefMethod.InstallExtensionFromGithub => "install_extension_from_github",
                ToolsBaseBrowserbaseIntegrationDefMethod.ListSessions => "list_sessions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseBrowserbaseIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "complete_session" => ToolsBaseBrowserbaseIntegrationDefMethod.CompleteSession,
                "create_context" => ToolsBaseBrowserbaseIntegrationDefMethod.CreateContext,
                "create_session" => ToolsBaseBrowserbaseIntegrationDefMethod.CreateSession,
                "get_connect_url" => ToolsBaseBrowserbaseIntegrationDefMethod.GetConnectUrl,
                "get_live_urls" => ToolsBaseBrowserbaseIntegrationDefMethod.GetLiveUrls,
                "get_logs" => ToolsBaseBrowserbaseIntegrationDefMethod.GetLogs,
                "get_recordings" => ToolsBaseBrowserbaseIntegrationDefMethod.GetRecordings,
                "get_session" => ToolsBaseBrowserbaseIntegrationDefMethod.GetSession,
                "get_session_downloads" => ToolsBaseBrowserbaseIntegrationDefMethod.GetSessionDownloads,
                "install_extension_from_github" => ToolsBaseBrowserbaseIntegrationDefMethod.InstallExtensionFromGithub,
                "list_sessions" => ToolsBaseBrowserbaseIntegrationDefMethod.ListSessions,
                _ => null,
            };
        }
    }
}