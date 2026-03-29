
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesCreateResponseToolChoiceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesCreateResponseToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCreateResponseToolChoiceEnum value)
        {
            return value switch
            {
                ResponsesCreateResponseToolChoiceEnum.Auto => "auto",
                ResponsesCreateResponseToolChoiceEnum.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCreateResponseToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesCreateResponseToolChoiceEnum.Auto,
                "none" => ResponsesCreateResponseToolChoiceEnum.None,
                _ => null,
            };
        }
    }
}