
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of response format being defined. Always `json_object`.
    /// </summary>
    public enum ResponsesResponseFormatJsonObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesResponseFormatJsonObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponseFormatJsonObjectType value)
        {
            return value switch
            {
                ResponsesResponseFormatJsonObjectType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponseFormatJsonObjectType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponsesResponseFormatJsonObjectType.JsonObject,
                _ => null,
            };
        }
    }
}