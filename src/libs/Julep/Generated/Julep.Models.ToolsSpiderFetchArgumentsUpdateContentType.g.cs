
#nullable enable

namespace Julep
{
    /// <summary>
    /// The content type to return<br/>
    /// Default Value: application/json
    /// </summary>
    public enum ToolsSpiderFetchArgumentsUpdateContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJsonl,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXml,
        /// <summary>
        /// 
        /// </summary>
        TextCsv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSpiderFetchArgumentsUpdateContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSpiderFetchArgumentsUpdateContentType value)
        {
            return value switch
            {
                ToolsSpiderFetchArgumentsUpdateContentType.ApplicationJson => "application/json",
                ToolsSpiderFetchArgumentsUpdateContentType.ApplicationJsonl => "application/jsonl",
                ToolsSpiderFetchArgumentsUpdateContentType.ApplicationXml => "application/xml",
                ToolsSpiderFetchArgumentsUpdateContentType.TextCsv => "text/csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSpiderFetchArgumentsUpdateContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => ToolsSpiderFetchArgumentsUpdateContentType.ApplicationJson,
                "application/jsonl" => ToolsSpiderFetchArgumentsUpdateContentType.ApplicationJsonl,
                "application/xml" => ToolsSpiderFetchArgumentsUpdateContentType.ApplicationXml,
                "text/csv" => ToolsSpiderFetchArgumentsUpdateContentType.TextCsv,
                _ => null,
            };
        }
    }
}