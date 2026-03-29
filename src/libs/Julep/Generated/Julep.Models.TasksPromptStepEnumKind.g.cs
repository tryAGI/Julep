
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksPromptStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepEnumKind value)
        {
            return value switch
            {
                TasksPromptStepEnumKind.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => TasksPromptStepEnumKind.Prompt,
                _ => null,
            };
        }
    }
}