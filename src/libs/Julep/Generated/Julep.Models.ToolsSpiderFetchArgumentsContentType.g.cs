
#nullable enable

namespace Julep
{
    /// <summary>
    /// The content type to return<br/>
    /// Default Value: application/json
    /// </summary>
    public enum ToolsSpiderFetchArgumentsContentType
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
    public static class ToolsSpiderFetchArgumentsContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSpiderFetchArgumentsContentType value)
        {
            return value switch
            {
                ToolsSpiderFetchArgumentsContentType.ApplicationJson => "application/json",
                ToolsSpiderFetchArgumentsContentType.ApplicationJsonl => "application/jsonl",
                ToolsSpiderFetchArgumentsContentType.ApplicationXml => "application/xml",
                ToolsSpiderFetchArgumentsContentType.TextCsv => "text/csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSpiderFetchArgumentsContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => ToolsSpiderFetchArgumentsContentType.ApplicationJson,
                "application/jsonl" => ToolsSpiderFetchArgumentsContentType.ApplicationJsonl,
                "application/xml" => ToolsSpiderFetchArgumentsContentType.ApplicationXml,
                "text/csv" => ToolsSpiderFetchArgumentsContentType.TextCsv,
                _ => null,
            };
        }
    }
}