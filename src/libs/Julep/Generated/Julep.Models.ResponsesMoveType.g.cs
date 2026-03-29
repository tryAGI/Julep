
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
    /// Default Value: move
    /// </summary>
    public enum ResponsesMoveType
    {
        /// <summary>
        /// 
        /// </summary>
        Move,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesMoveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesMoveType value)
        {
            return value switch
            {
                ResponsesMoveType.Move => "move",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesMoveType? ToEnum(string value)
        {
            return value switch
            {
                "move" => ResponsesMoveType.Move,
                _ => null,
            };
        }
    }
}