
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksToolCallStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksToolCallStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksToolCallStepEnumKind value)
        {
            return value switch
            {
                TasksToolCallStepEnumKind.ToolCall => "tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksToolCallStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "tool_call" => TasksToolCallStepEnumKind.ToolCall,
                _ => null,
            };
        }
    }
}