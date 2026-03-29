
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "LlamaParseSetup"<br/>
    /// Default Value: llama_parse
    /// </summary>
    public enum ToolsLlamaParseIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        LlamaParse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsLlamaParseIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsLlamaParseIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsLlamaParseIntegrationDefProvider.LlamaParse => "llama_parse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsLlamaParseIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "llama_parse" => ToolsLlamaParseIntegrationDefProvider.LlamaParse,
                _ => null,
            };
        }
    }
}