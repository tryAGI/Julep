
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesIncludable
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCallOutputOutputImageUrl,
        /// <summary>
        /// 
        /// </summary>
        FileSearchCallResults,
        /// <summary>
        /// 
        /// </summary>
        MessageInputImageImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesIncludableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesIncludable value)
        {
            return value switch
            {
                ResponsesIncludable.ComputerCallOutputOutputImageUrl => "computer_call_output.output.image_url",
                ResponsesIncludable.FileSearchCallResults => "file_search_call.results",
                ResponsesIncludable.MessageInputImageImageUrl => "message.input_image.image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesIncludable? ToEnum(string value)
        {
            return value switch
            {
                "computer_call_output.output.image_url" => ResponsesIncludable.ComputerCallOutputOutputImageUrl,
                "file_search_call.results" => ResponsesIncludable.FileSearchCallResults,
                "message.input_image.image_url" => ResponsesIncludable.MessageInputImageImageUrl,
                _ => null,
            };
        }
    }
}