
#nullable enable

namespace Julep
{
    /// <summary>
    /// Sub-resource type (if applicable)
    /// </summary>
    public enum ToolsSystemDefSubresource
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
    public static class ToolsSystemDefSubresourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSystemDefSubresource value)
        {
            return value switch
            {
                ToolsSystemDefSubresource.Doc => "doc",
                ToolsSystemDefSubresource.Execution => "execution",
                ToolsSystemDefSubresource.Tool => "tool",
                ToolsSystemDefSubresource.Transition => "transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSystemDefSubresource? ToEnum(string value)
        {
            return value switch
            {
                "doc" => ToolsSystemDefSubresource.Doc,
                "execution" => ToolsSystemDefSubresource.Execution,
                "tool" => ToolsSystemDefSubresource.Tool,
                "transition" => ToolsSystemDefSubresource.Transition,
                _ => null,
            };
        }
    }
}