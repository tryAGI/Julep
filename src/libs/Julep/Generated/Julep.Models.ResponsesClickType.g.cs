
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a click action, this property is always set to `click`.<br/>
    /// Default Value: click
    /// </summary>
    public enum ResponsesClickType
    {
        /// <summary>
        /// 
        /// </summary>
        Click,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesClickTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesClickType value)
        {
            return value switch
            {
                ResponsesClickType.Click => "click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesClickType? ToEnum(string value)
        {
            return value switch
            {
                "click" => ResponsesClickType.Click,
                _ => null,
            };
        }
    }
}