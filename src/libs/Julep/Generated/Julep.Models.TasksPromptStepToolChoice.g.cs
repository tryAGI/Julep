
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksPromptStepToolChoice
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
    public static class TasksPromptStepToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepToolChoice value)
        {
            return value switch
            {
                TasksPromptStepToolChoice.Auto => "auto",
                TasksPromptStepToolChoice.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TasksPromptStepToolChoice.Auto,
                "none" => TasksPromptStepToolChoice.None,
                _ => null,
            };
        }
    }
}