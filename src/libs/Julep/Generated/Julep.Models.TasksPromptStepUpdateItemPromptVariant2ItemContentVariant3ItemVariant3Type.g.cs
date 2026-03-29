
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: tool_result
    /// </summary>
    public enum TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type value)
        {
            return value switch
            {
                TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type.ToolResult,
                _ => null,
            };
        }
    }
}