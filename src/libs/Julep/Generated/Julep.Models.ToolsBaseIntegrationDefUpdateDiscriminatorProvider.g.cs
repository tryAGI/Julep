
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsBaseIntegrationDefUpdateDiscriminatorProvider
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
    public static class ToolsBaseIntegrationDefUpdateDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseIntegrationDefUpdateDiscriminatorProvider value)
        {
            return value switch
            {
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Algolia => "algolia",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Arxiv => "arxiv",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Brave => "brave",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Browserbase => "browserbase",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Cloudinary => "cloudinary",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Email => "email",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Ffmpeg => "ffmpeg",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.GoogleSheets => "google_sheets",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.LlamaParse => "llama_parse",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Mailgun => "mailgun",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Mcp => "mcp",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.RemoteBrowser => "remote_browser",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Spider => "spider",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Unstructured => "unstructured",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Weather => "weather",
                ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Wikipedia => "wikipedia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseIntegrationDefUpdateDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "algolia" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Algolia,
                "arxiv" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Arxiv,
                "brave" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Brave,
                "browserbase" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Browserbase,
                "cloudinary" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Cloudinary,
                "email" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Email,
                "ffmpeg" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Ffmpeg,
                "google_sheets" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.GoogleSheets,
                "llama_parse" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.LlamaParse,
                "mailgun" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Mailgun,
                "mcp" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Mcp,
                "remote_browser" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.RemoteBrowser,
                "spider" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Spider,
                "unstructured" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Unstructured,
                "weather" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Weather,
                "wikipedia" => ToolsBaseIntegrationDefUpdateDiscriminatorProvider.Wikipedia,
                _ => null,
            };
        }
    }
}