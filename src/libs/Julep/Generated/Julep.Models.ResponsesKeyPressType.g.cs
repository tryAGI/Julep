
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a keypress action, this property is always set to `keypress`.<br/>
    /// Default Value: keypress
    /// </summary>
    public enum ResponsesKeyPressType
    {
        /// <summary>
        /// 
        /// </summary>
        Keypress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesKeyPressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesKeyPressType value)
        {
            return value switch
            {
                ResponsesKeyPressType.Keypress => "keypress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesKeyPressType? ToEnum(string value)
        {
            return value switch
            {
                "keypress" => ResponsesKeyPressType.Keypress,
                _ => null,
            };
        }
    }
}