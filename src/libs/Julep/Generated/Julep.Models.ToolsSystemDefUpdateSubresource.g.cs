
#nullable enable

namespace Julep
{
    /// <summary>
    /// Sub-resource type (if applicable)
    /// </summary>
    public enum ToolsSystemDefUpdateSubresource
    {
        /// <summary>
        /// 
        /// </summary>
        Doc,
        /// <summary>
        /// 
        /// </summary>
        Execution,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Transition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSystemDefUpdateSubresourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSystemDefUpdateSubresource value)
        {
            return value switch
            {
                ToolsSystemDefUpdateSubresource.Doc => "doc",
                ToolsSystemDefUpdateSubresource.Execution => "execution",
                ToolsSystemDefUpdateSubresource.Tool => "tool",
                ToolsSystemDefUpdateSubresource.Transition => "transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSystemDefUpdateSubresource? ToEnum(string value)
        {
            return value switch
            {
                "doc" => ToolsSystemDefUpdateSubresource.Doc,
                "execution" => ToolsSystemDefUpdateSubresource.Execution,
                "tool" => ToolsSystemDefUpdateSubresource.Tool,
                "transition" => ToolsSystemDefUpdateSubresource.Transition,
                _ => null,
            };
        }
    }
}