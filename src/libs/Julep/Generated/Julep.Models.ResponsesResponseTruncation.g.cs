
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesResponseTruncation
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesResponseTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponseTruncation value)
        {
            return value switch
            {
                ResponsesResponseTruncation.Auto => "auto",
                ResponsesResponseTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponseTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesResponseTruncation.Auto,
                "disabled" => ResponsesResponseTruncation.Disabled,
                _ => null,
            };
        }
    }
}