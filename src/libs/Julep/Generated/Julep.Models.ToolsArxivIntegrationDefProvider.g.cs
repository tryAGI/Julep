
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "arxiv"<br/>
    /// Default Value: arxiv
    /// </summary>
    public enum ToolsArxivIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Arxiv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsArxivIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsArxivIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsArxivIntegrationDefProvider.Arxiv => "arxiv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsArxivIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "arxiv" => ToolsArxivIntegrationDefProvider.Arxiv,
                _ => null,
            };
        }
    }
}