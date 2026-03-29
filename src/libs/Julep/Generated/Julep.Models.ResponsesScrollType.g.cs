
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a scroll action, this property is always set to `scroll`.<br/>
    /// Default Value: scroll
    /// </summary>
    public enum ResponsesScrollType
    {
        /// <summary>
        /// 
        /// </summary>
        Scroll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesScrollTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesScrollType value)
        {
            return value switch
            {
                ResponsesScrollType.Scroll => "scroll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesScrollType? ToEnum(string value)
        {
            return value switch
            {
                "scroll" => ResponsesScrollType.Scroll,
                _ => null,
            };
        }
    }
}