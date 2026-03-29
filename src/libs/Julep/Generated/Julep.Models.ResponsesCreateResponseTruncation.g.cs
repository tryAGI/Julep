
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesCreateResponseTruncation
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
    public static class ResponsesCreateResponseTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesCreateResponseTruncation value)
        {
            return value switch
            {
                ResponsesCreateResponseTruncation.Auto => "auto",
                ResponsesCreateResponseTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesCreateResponseTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesCreateResponseTruncation.Auto,
                "disabled" => ResponsesCreateResponseTruncation.Disabled,
                _ => null,
            };
        }
    }
}