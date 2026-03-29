
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiCall,
        /// <summary>
        /// 
        /// </summary>
        Bash20241022,
        /// <summary>
        /// 
        /// </summary>
        Computer20241022,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        TextEditor20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsToolType value)
        {
            return value switch
            {
                ToolsToolType.ApiCall => "api_call",
                ToolsToolType.Bash20241022 => "bash_20241022",
                ToolsToolType.Computer20241022 => "computer_20241022",
                ToolsToolType.Function => "function",
                ToolsToolType.Integration => "integration",
                ToolsToolType.System => "system",
                ToolsToolType.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsToolType? ToEnum(string value)
        {
            return value switch
            {
                "api_call" => ToolsToolType.ApiCall,
                "bash_20241022" => ToolsToolType.Bash20241022,
                "computer_20241022" => ToolsToolType.Computer20241022,
                "function" => ToolsToolType.Function,
                "integration" => ToolsToolType.Integration,
                "system" => ToolsToolType.System,
                "text_editor_20241022" => ToolsToolType.TextEditor20241022,
                _ => null,
            };
        }
    }
}