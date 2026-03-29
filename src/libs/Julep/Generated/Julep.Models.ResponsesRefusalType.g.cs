
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the refusal. Always `refusal`.
    /// </summary>
    public enum ResponsesRefusalType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRefusalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRefusalType value)
        {
            return value switch
            {
                ResponsesRefusalType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRefusalType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => ResponsesRefusalType.Refusal,
                _ => null,
            };
        }
    }
}