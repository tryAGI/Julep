
#nullable enable

namespace Julep
{
    /// <summary>
    /// ChatML role (system|assistant|user|tool)
    /// </summary>
    public enum EntriesChatMLRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntriesChatMLRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntriesChatMLRole value)
        {
            return value switch
            {
                EntriesChatMLRole.Assistant => "assistant",
                EntriesChatMLRole.System => "system",
                EntriesChatMLRole.Tool => "tool",
                EntriesChatMLRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntriesChatMLRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EntriesChatMLRole.Assistant,
                "system" => EntriesChatMLRole.System,
                "tool" => EntriesChatMLRole.Tool,
                "user" => EntriesChatMLRole.User,
                _ => null,
            };
        }
    }
}