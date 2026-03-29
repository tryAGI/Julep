
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the input item. Always `input_image`.
    /// </summary>
    public enum ResponsesInputImageType
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputImageType value)
        {
            return value switch
            {
                ResponsesInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => ResponsesInputImageType.InputImage,
                _ => null,
            };
        }
    }
}