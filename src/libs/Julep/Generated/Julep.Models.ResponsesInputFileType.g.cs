
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the input item. Always `input_file`.
    /// </summary>
    public enum ResponsesInputFileType
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputFileType value)
        {
            return value switch
            {
                ResponsesInputFileType.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputFileType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => ResponsesInputFileType.InputFile,
                _ => null,
            };
        }
    }
}