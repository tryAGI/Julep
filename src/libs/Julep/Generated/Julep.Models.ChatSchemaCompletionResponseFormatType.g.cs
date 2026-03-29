
#nullable enable

namespace Julep
{
    /// <summary>
    /// The format of the response<br/>
    /// Default Value: json_schema
    /// </summary>
    public enum ChatSchemaCompletionResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSchemaCompletionResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSchemaCompletionResponseFormatType value)
        {
            return value switch
            {
                ChatSchemaCompletionResponseFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSchemaCompletionResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ChatSchemaCompletionResponseFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}