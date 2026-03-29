
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider of the integration
    /// </summary>
    public enum ToolsBaseIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Algolia,
        /// <summary>
        /// 
        /// </summary>
        Arxiv,
        /// <summary>
        /// 
        /// </summary>
        Brave,
        /// <summary>
        /// 
        /// </summary>
        Browserbase,
        /// <summary>
        /// 
        /// </summary>
        Cloudinary,
        /// <summary>
        /// 
        /// </summary>
        Dummy,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Ffmpeg,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheets,
        /// <summary>
        /// 
        /// </summary>
        LlamaParse,
        /// <summary>
        /// 
        /// </summary>
        Mailgun,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        RemoteBrowser,
        /// <summary>
        /// 
        /// </summary>
        Spider,
        /// <summary>
        /// 
        /// </summary>
        Unstructured,
        /// <summary>
        /// 
        /// </summary>
        Weather,
        /// <summary>
        /// 
        /// </summary>
        Wikipedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsBaseIntegrationDefUpdateProvider.Algolia => "algolia",
                ToolsBaseIntegrationDefUpdateProvider.Arxiv => "arxiv",
                ToolsBaseIntegrationDefUpdateProvider.Brave => "brave",
                ToolsBaseIntegrationDefUpdateProvider.Browserbase => "browserbase",
                ToolsBaseIntegrationDefUpdateProvider.Cloudinary => "cloudinary",
                ToolsBaseIntegrationDefUpdateProvider.Dummy => "dummy",
                ToolsBaseIntegrationDefUpdateProvider.Email => "email",
                ToolsBaseIntegrationDefUpdateProvider.Ffmpeg => "ffmpeg",
                ToolsBaseIntegrationDefUpdateProvider.GoogleSheets => "google_sheets",
                ToolsBaseIntegrationDefUpdateProvider.LlamaParse => "llama_parse",
                ToolsBaseIntegrationDefUpdateProvider.Mailgun => "mailgun",
                ToolsBaseIntegrationDefUpdateProvider.Mcp => "mcp",
                ToolsBaseIntegrationDefUpdateProvider.RemoteBrowser => "remote_browser",
                ToolsBaseIntegrationDefUpdateProvider.Spider => "spider",
                ToolsBaseIntegrationDefUpdateProvider.Unstructured => "unstructured",
                ToolsBaseIntegrationDefUpdateProvider.Weather => "weather",
                ToolsBaseIntegrationDefUpdateProvider.Wikipedia => "wikipedia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "algolia" => ToolsBaseIntegrationDefUpdateProvider.Algolia,
                "arxiv" => ToolsBaseIntegrationDefUpdateProvider.Arxiv,
                "brave" => ToolsBaseIntegrationDefUpdateProvider.Brave,
                "browserbase" => ToolsBaseIntegrationDefUpdateProvider.Browserbase,
                "cloudinary" => ToolsBaseIntegrationDefUpdateProvider.Cloudinary,
                "dummy" => ToolsBaseIntegrationDefUpdateProvider.Dummy,
                "email" => ToolsBaseIntegrationDefUpdateProvider.Email,
                "ffmpeg" => ToolsBaseIntegrationDefUpdateProvider.Ffmpeg,
                "google_sheets" => ToolsBaseIntegrationDefUpdateProvider.GoogleSheets,
                "llama_parse" => ToolsBaseIntegrationDefUpdateProvider.LlamaParse,
                "mailgun" => ToolsBaseIntegrationDefUpdateProvider.Mailgun,
                "mcp" => ToolsBaseIntegrationDefUpdateProvider.Mcp,
                "remote_browser" => ToolsBaseIntegrationDefUpdateProvider.RemoteBrowser,
                "spider" => ToolsBaseIntegrationDefUpdateProvider.Spider,
                "unstructured" => ToolsBaseIntegrationDefUpdateProvider.Unstructured,
                "weather" => ToolsBaseIntegrationDefUpdateProvider.Weather,
                "wikipedia" => ToolsBaseIntegrationDefUpdateProvider.Wikipedia,
                _ => null,
            };
        }
    }
}