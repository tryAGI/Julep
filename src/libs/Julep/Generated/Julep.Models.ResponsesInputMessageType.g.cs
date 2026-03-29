
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesInputMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputMessageType value)
        {
            return value switch
            {
                ResponsesInputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ResponsesInputMessageType.Message,
                _ => null,
            };
        }
    }
}