
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsComputer20241022Action
    {
        /// <summary>
        /// 
        /// </summary>
        CursorPosition,
        /// <summary>
        /// 
        /// </summary>
        DoubleClick,
        /// <summary>
        /// 
        /// </summary>
        Key,
        /// <summary>
        /// 
        /// </summary>
        LeftClick,
        /// <summary>
        /// 
        /// </summary>
        MiddleClick,
        /// <summary>
        /// 
        /// </summary>
        MouseMove,
        /// <summary>
        /// 
        /// </summary>
        RightClick,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsComputer20241022ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsComputer20241022Action value)
        {
            return value switch
            {
                ToolsComputer20241022Action.CursorPosition => "cursor_position",
                ToolsComputer20241022Action.DoubleClick => "double_click",
                ToolsComputer20241022Action.Key => "key",
                ToolsComputer20241022Action.LeftClick => "left_click",
                ToolsComputer20241022Action.MiddleClick => "middle_click",
                ToolsComputer20241022Action.MouseMove => "mouse_move",
                ToolsComputer20241022Action.RightClick => "right_click",
                ToolsComputer20241022Action.Screenshot => "screenshot",
                ToolsComputer20241022Action.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsComputer20241022Action? ToEnum(string value)
        {
            return value switch
            {
                "cursor_position" => ToolsComputer20241022Action.CursorPosition,
                "double_click" => ToolsComputer20241022Action.DoubleClick,
                "key" => ToolsComputer20241022Action.Key,
                "left_click" => ToolsComputer20241022Action.LeftClick,
                "middle_click" => ToolsComputer20241022Action.MiddleClick,
                "mouse_move" => ToolsComputer20241022Action.MouseMove,
                "right_click" => ToolsComputer20241022Action.RightClick,
                "screenshot" => ToolsComputer20241022Action.Screenshot,
                "type" => ToolsComputer20241022Action.Type,
                _ => null,
            };
        }
    }
}