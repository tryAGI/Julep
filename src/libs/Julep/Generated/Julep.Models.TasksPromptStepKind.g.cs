
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: prompt<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksPromptStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepKind value)
        {
            return value switch
            {
                TasksPromptStepKind.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepKind? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => TasksPromptStepKind.Prompt,
                _ => null,
            };
        }
    }
}