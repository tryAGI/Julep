
#nullable enable

namespace Julep
{
    /// <summary>
    /// The format of the response<br/>
    /// Default Value: text
    /// </summary>
    public enum ChatSimpleCompletionResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSimpleCompletionResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSimpleCompletionResponseFormatType value)
        {
            return value switch
            {
                ChatSimpleCompletionResponseFormatType.JsonObject => "json_object",
                ChatSimpleCompletionResponseFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSimpleCompletionResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatSimpleCompletionResponseFormatType.JsonObject,
                "text" => ChatSimpleCompletionResponseFormatType.Text,
                _ => null,
            };
        }
    }
}