
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of response format being defined. Always `text`.
    /// </summary>
    public enum ResponsesResponseFormatTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesResponseFormatTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponseFormatTextType value)
        {
            return value switch
            {
                ResponsesResponseFormatTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponseFormatTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponsesResponseFormatTextType.Text,
                _ => null,
            };
        }
    }
}