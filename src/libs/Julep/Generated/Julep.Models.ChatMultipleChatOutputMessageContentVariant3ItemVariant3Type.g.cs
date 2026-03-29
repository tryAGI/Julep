
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: tool_result
    /// </summary>
    public enum ChatMultipleChatOutputMessageContentVariant3ItemVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMultipleChatOutputMessageContentVariant3ItemVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMultipleChatOutputMessageContentVariant3ItemVariant3Type value)
        {
            return value switch
            {
                ChatMultipleChatOutputMessageContentVariant3ItemVariant3Type.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMultipleChatOutputMessageContentVariant3ItemVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => ChatMultipleChatOutputMessageContentVariant3ItemVariant3Type.ToolResult,
                _ => null,
            };
        }
    }
}