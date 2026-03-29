
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesMessageRole value)
        {
            return value switch
            {
                ResponsesMessageRole.Assistant => "assistant",
                ResponsesMessageRole.Developer => "developer",
                ResponsesMessageRole.System => "system",
                ResponsesMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponsesMessageRole.Assistant,
                "developer" => ResponsesMessageRole.Developer,
                "system" => ResponsesMessageRole.System,
                "user" => ResponsesMessageRole.User,
                _ => null,
            };
        }
    }
}