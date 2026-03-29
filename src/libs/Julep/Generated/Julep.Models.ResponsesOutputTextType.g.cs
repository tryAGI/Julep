
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the output text. Always `output_text`.
    /// </summary>
    public enum ResponsesOutputTextType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesOutputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesOutputTextType value)
        {
            return value switch
            {
                ResponsesOutputTextType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesOutputTextType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => ResponsesOutputTextType.OutputText,
                _ => null,
            };
        }
    }
}