
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksPromptStepUpdateItemTools
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepUpdateItemToolsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepUpdateItemTools value)
        {
            return value switch
            {
                TasksPromptStepUpdateItemTools.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepUpdateItemTools? ToEnum(string value)
        {
            return value switch
            {
                "all" => TasksPromptStepUpdateItemTools.All,
                _ => null,
            };
        }
    }
}