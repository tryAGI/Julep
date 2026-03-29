
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: tool_call<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksToolCallStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksToolCallStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksToolCallStepKind value)
        {
            return value switch
            {
                TasksToolCallStepKind.ToolCall => "tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksToolCallStepKind? ToEnum(string value)
        {
            return value switch
            {
                "tool_call" => TasksToolCallStepKind.ToolCall,
                _ => null,
            };
        }
    }
}