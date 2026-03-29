
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider of the integration
    /// </summary>
    public enum ToolsBaseIntegrationDefProvider
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
    public static class ToolsBaseIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsBaseIntegrationDefProvider.Algolia => "algolia",
                ToolsBaseIntegrationDefProvider.Arxiv => "arxiv",
                ToolsBaseIntegrationDefProvider.Brave => "brave",
                ToolsBaseIntegrationDefProvider.Browserbase => "browserbase",
                ToolsBaseIntegrationDefProvider.Cloudinary => "cloudinary",
                ToolsBaseIntegrationDefProvider.Dummy => "dummy",
                ToolsBaseIntegrationDefProvider.Email => "email",
                ToolsBaseIntegrationDefProvider.Ffmpeg => "ffmpeg",
                ToolsBaseIntegrationDefProvider.GoogleSheets => "google_sheets",
                ToolsBaseIntegrationDefProvider.LlamaParse => "llama_parse",
                ToolsBaseIntegrationDefProvider.Mailgun => "mailgun",
                ToolsBaseIntegrationDefProvider.Mcp => "mcp",
                ToolsBaseIntegrationDefProvider.RemoteBrowser => "remote_browser",
                ToolsBaseIntegrationDefProvider.Spider => "spider",
                ToolsBaseIntegrationDefProvider.Unstructured => "unstructured",
                ToolsBaseIntegrationDefProvider.Weather => "weather",
                ToolsBaseIntegrationDefProvider.Wikipedia => "wikipedia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "algolia" => ToolsBaseIntegrationDefProvider.Algolia,
                "arxiv" => ToolsBaseIntegrationDefProvider.Arxiv,
                "brave" => ToolsBaseIntegrationDefProvider.Brave,
                "browserbase" => ToolsBaseIntegrationDefProvider.Browserbase,
                "cloudinary" => ToolsBaseIntegrationDefProvider.Cloudinary,
                "dummy" => ToolsBaseIntegrationDefProvider.Dummy,
                "email" => ToolsBaseIntegrationDefProvider.Email,
                "ffmpeg" => ToolsBaseIntegrationDefProvider.Ffmpeg,
                "google_sheets" => ToolsBaseIntegrationDefProvider.GoogleSheets,
                "llama_parse" => ToolsBaseIntegrationDefProvider.LlamaParse,
                "mailgun" => ToolsBaseIntegrationDefProvider.Mailgun,
                "mcp" => ToolsBaseIntegrationDefProvider.Mcp,
                "remote_browser" => ToolsBaseIntegrationDefProvider.RemoteBrowser,
                "spider" => ToolsBaseIntegrationDefProvider.Spider,
                "unstructured" => ToolsBaseIntegrationDefProvider.Unstructured,
                "weather" => ToolsBaseIntegrationDefProvider.Weather,
                "wikipedia" => ToolsBaseIntegrationDefProvider.Wikipedia,
                _ => null,
            };
        }
    }
}