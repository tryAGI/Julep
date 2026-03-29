
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "LlamaParseSetup"<br/>
    /// Default Value: llama_parse
    /// </summary>
    public enum ToolsLlamaParseIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        LlamaParse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsLlamaParseIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsLlamaParseIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsLlamaParseIntegrationDefUpdateProvider.LlamaParse => "llama_parse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsLlamaParseIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "llama_parse" => ToolsLlamaParseIntegrationDefUpdateProvider.LlamaParse,
                _ => null,
            };
        }
    }
}