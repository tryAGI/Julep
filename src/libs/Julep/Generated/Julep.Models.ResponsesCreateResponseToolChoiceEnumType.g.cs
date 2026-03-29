
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesCreateResponseToolChoiceEnumType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCreateResponseToolChoiceEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCreateResponseToolChoiceEnumType value)
        {
            return value switch
            {
                ResponsesCreateResponseToolChoiceEnumType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCreateResponseToolChoiceEnumType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ResponsesCreateResponseToolChoiceEnumType.Function,
                _ => null,
            };
        }
    }
}