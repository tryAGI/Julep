
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of response format being defined. Always `json_schema`.
    /// </summary>
    public enum ResponsesTextResponseFormatJsonSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesTextResponseFormatJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesTextResponseFormatJsonSchemaType value)
        {
            return value switch
            {
                ResponsesTextResponseFormatJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesTextResponseFormatJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ResponsesTextResponseFormatJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}