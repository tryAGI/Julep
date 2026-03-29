
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "arxiv"<br/>
    /// Default Value: arxiv
    /// </summary>
    public enum ToolsArxivIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Arxiv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsArxivIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsArxivIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsArxivIntegrationDefUpdateProvider.Arxiv => "arxiv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsArxivIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "arxiv" => ToolsArxivIntegrationDefUpdateProvider.Arxiv,
                _ => null,
            };
        }
    }
}