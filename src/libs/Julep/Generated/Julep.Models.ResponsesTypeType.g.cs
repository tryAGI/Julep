
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
    /// Default Value: type
    /// </summary>
    public enum ResponsesTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesTypeType value)
        {
            return value switch
            {
                ResponsesTypeType.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesTypeType? ToEnum(string value)
        {
            return value switch
            {
                "type" => ResponsesTypeType.Type,
                _ => null,
            };
        }
    }
}