
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the object. Always `reasoning`.
    /// </summary>
    public enum ResponsesReasoningItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningItemType value)
        {
            return value switch
            {
                ResponsesReasoningItemType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => ResponsesReasoningItemType.Reasoning,
                _ => null,
            };
        }
    }
}