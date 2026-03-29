
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatChatInputDataToolChoice
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
    public static class ChatChatInputDataToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatChatInputDataToolChoice value)
        {
            return value switch
            {
                ChatChatInputDataToolChoice.Auto => "auto",
                ChatChatInputDataToolChoice.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatChatInputDataToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatChatInputDataToolChoice.Auto,
                "none" => ChatChatInputDataToolChoice.None,
                _ => null,
            };
        }
    }
}