
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesToolChoiceOptions
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesToolChoiceOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesToolChoiceOptions value)
        {
            return value switch
            {
                ResponsesToolChoiceOptions.Auto => "auto",
                ResponsesToolChoiceOptions.None => "none",
                ResponsesToolChoiceOptions.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesToolChoiceOptions? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesToolChoiceOptions.Auto,
                "none" => ResponsesToolChoiceOptions.None,
                "required" => ResponsesToolChoiceOptions.Required,
                _ => null,
            };
        }
    }
}