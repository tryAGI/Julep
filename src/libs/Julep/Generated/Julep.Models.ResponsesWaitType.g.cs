
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
    /// Default Value: wait
    /// </summary>
    public enum ResponsesWaitType
    {
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWaitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWaitType value)
        {
            return value switch
            {
                ResponsesWaitType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWaitType? ToEnum(string value)
        {
            return value switch
            {
                "wait" => ResponsesWaitType.Wait,
                _ => null,
            };
        }
    }
}