
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the message input. Always `message`.
    /// </summary>
    public enum ResponsesEasyInputMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesEasyInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesEasyInputMessageType value)
        {
            return value switch
            {
                ResponsesEasyInputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesEasyInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ResponsesEasyInputMessageType.Message,
                _ => null,
            };
        }
    }
}