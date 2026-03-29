
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesWebSearchToolUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchToolUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchToolUserLocationType value)
        {
            return value switch
            {
                ResponsesWebSearchToolUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchToolUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => ResponsesWebSearchToolUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}