
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksPromptStepTools
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepToolsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepTools value)
        {
            return value switch
            {
                TasksPromptStepTools.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepTools? ToEnum(string value)
        {
            return value switch
            {
                "all" => TasksPromptStepTools.All,
                _ => null,
            };
        }
    }
}