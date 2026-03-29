
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntriesBaseEntrySource
    {
        /// <summary>
        /// 
        /// </summary>
        ApiRequest,
        /// <summary>
        /// 
        /// </summary>
        ApiResponse,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Meta,
        /// <summary>
        /// 
        /// </summary>
        Summarizer,
        /// <summary>
        /// 
        /// </summary>
        ToolRequest,
        /// <summary>
        /// 
        /// </summary>
        ToolResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntriesBaseEntrySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntriesBaseEntrySource value)
        {
            return value switch
            {
                EntriesBaseEntrySource.ApiRequest => "api_request",
                EntriesBaseEntrySource.ApiResponse => "api_response",
                EntriesBaseEntrySource.Internal => "internal",
                EntriesBaseEntrySource.Meta => "meta",
                EntriesBaseEntrySource.Summarizer => "summarizer",
                EntriesBaseEntrySource.ToolRequest => "tool_request",
                EntriesBaseEntrySource.ToolResponse => "tool_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntriesBaseEntrySource? ToEnum(string value)
        {
            return value switch
            {
                "api_request" => EntriesBaseEntrySource.ApiRequest,
                "api_response" => EntriesBaseEntrySource.ApiResponse,
                "internal" => EntriesBaseEntrySource.Internal,
                "meta" => EntriesBaseEntrySource.Meta,
                "summarizer" => EntriesBaseEntrySource.Summarizer,
                "tool_request" => EntriesBaseEntrySource.ToolRequest,
                "tool_response" => EntriesBaseEntrySource.ToolResponse,
                _ => null,
            };
        }
    }
}