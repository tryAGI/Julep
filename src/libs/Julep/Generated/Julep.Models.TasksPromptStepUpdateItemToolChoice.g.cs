
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksPromptStepUpdateItemToolChoice
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
    public static class TasksPromptStepUpdateItemToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepUpdateItemToolChoice value)
        {
            return value switch
            {
                TasksPromptStepUpdateItemToolChoice.Auto => "auto",
                TasksPromptStepUpdateItemToolChoice.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepUpdateItemToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TasksPromptStepUpdateItemToolChoice.Auto,
                "none" => TasksPromptStepUpdateItemToolChoice.None,
                _ => null,
            };
        }
    }
}