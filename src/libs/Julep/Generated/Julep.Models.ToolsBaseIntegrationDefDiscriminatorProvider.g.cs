
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsBaseIntegrationDefDiscriminatorProvider
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
    public static class ToolsBaseIntegrationDefDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseIntegrationDefDiscriminatorProvider value)
        {
            return value switch
            {
                ToolsBaseIntegrationDefDiscriminatorProvider.Algolia => "algolia",
                ToolsBaseIntegrationDefDiscriminatorProvider.Arxiv => "arxiv",
                ToolsBaseIntegrationDefDiscriminatorProvider.Brave => "brave",
                ToolsBaseIntegrationDefDiscriminatorProvider.Browserbase => "browserbase",
                ToolsBaseIntegrationDefDiscriminatorProvider.Cloudinary => "cloudinary",
                ToolsBaseIntegrationDefDiscriminatorProvider.Email => "email",
                ToolsBaseIntegrationDefDiscriminatorProvider.Ffmpeg => "ffmpeg",
                ToolsBaseIntegrationDefDiscriminatorProvider.GoogleSheets => "google_sheets",
                ToolsBaseIntegrationDefDiscriminatorProvider.LlamaParse => "llama_parse",
                ToolsBaseIntegrationDefDiscriminatorProvider.Mailgun => "mailgun",
                ToolsBaseIntegrationDefDiscriminatorProvider.Mcp => "mcp",
                ToolsBaseIntegrationDefDiscriminatorProvider.RemoteBrowser => "remote_browser",
                ToolsBaseIntegrationDefDiscriminatorProvider.Spider => "spider",
                ToolsBaseIntegrationDefDiscriminatorProvider.Unstructured => "unstructured",
                ToolsBaseIntegrationDefDiscriminatorProvider.Weather => "weather",
                ToolsBaseIntegrationDefDiscriminatorProvider.Wikipedia => "wikipedia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseIntegrationDefDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "algolia" => ToolsBaseIntegrationDefDiscriminatorProvider.Algolia,
                "arxiv" => ToolsBaseIntegrationDefDiscriminatorProvider.Arxiv,
                "brave" => ToolsBaseIntegrationDefDiscriminatorProvider.Brave,
                "browserbase" => ToolsBaseIntegrationDefDiscriminatorProvider.Browserbase,
                "cloudinary" => ToolsBaseIntegrationDefDiscriminatorProvider.Cloudinary,
                "email" => ToolsBaseIntegrationDefDiscriminatorProvider.Email,
                "ffmpeg" => ToolsBaseIntegrationDefDiscriminatorProvider.Ffmpeg,
                "google_sheets" => ToolsBaseIntegrationDefDiscriminatorProvider.GoogleSheets,
                "llama_parse" => ToolsBaseIntegrationDefDiscriminatorProvider.LlamaParse,
                "mailgun" => ToolsBaseIntegrationDefDiscriminatorProvider.Mailgun,
                "mcp" => ToolsBaseIntegrationDefDiscriminatorProvider.Mcp,
                "remote_browser" => ToolsBaseIntegrationDefDiscriminatorProvider.RemoteBrowser,
                "spider" => ToolsBaseIntegrationDefDiscriminatorProvider.Spider,
                "unstructured" => ToolsBaseIntegrationDefDiscriminatorProvider.Unstructured,
                "weather" => ToolsBaseIntegrationDefDiscriminatorProvider.Weather,
                "wikipedia" => ToolsBaseIntegrationDefDiscriminatorProvider.Wikipedia,
                _ => null,
            };
        }
    }
}