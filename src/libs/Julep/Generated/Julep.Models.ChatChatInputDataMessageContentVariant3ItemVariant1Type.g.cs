
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type (fixed to 'text')<br/>
    /// Default Value: text
    /// </summary>
    public enum ChatChatInputDataMessageContentVariant3ItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatChatInputDataMessageContentVariant3ItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatChatInputDataMessageContentVariant3ItemVariant1Type value)
        {
            return value switch
            {
                ChatChatInputDataMessageContentVariant3ItemVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatChatInputDataMessageContentVariant3ItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatChatInputDataMessageContentVariant3ItemVariant1Type.Text,
                _ => null,
            };
        }
    }
}