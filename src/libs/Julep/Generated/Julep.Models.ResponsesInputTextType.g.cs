
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the input item. Always `input_text`.
    /// </summary>
    public enum ResponsesInputTextType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputTextType value)
        {
            return value switch
            {
                ResponsesInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => ResponsesInputTextType.InputText,
                _ => null,
            };
        }
    }
}