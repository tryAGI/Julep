
#nullable enable

namespace Julep
{
    /// <summary>
    /// The action to perform
    /// </summary>
    public enum ToolsRemoteBrowserArgumentsAction
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
        LeftClickDrag,
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
        Navigate,
        /// <summary>
        /// 
        /// </summary>
        Refresh,
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
    public static class ToolsRemoteBrowserArgumentsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsRemoteBrowserArgumentsAction value)
        {
            return value switch
            {
                ToolsRemoteBrowserArgumentsAction.CursorPosition => "cursor_position",
                ToolsRemoteBrowserArgumentsAction.DoubleClick => "double_click",
                ToolsRemoteBrowserArgumentsAction.Key => "key",
                ToolsRemoteBrowserArgumentsAction.LeftClick => "left_click",
                ToolsRemoteBrowserArgumentsAction.LeftClickDrag => "left_click_drag",
                ToolsRemoteBrowserArgumentsAction.MiddleClick => "middle_click",
                ToolsRemoteBrowserArgumentsAction.MouseMove => "mouse_move",
                ToolsRemoteBrowserArgumentsAction.Navigate => "navigate",
                ToolsRemoteBrowserArgumentsAction.Refresh => "refresh",
                ToolsRemoteBrowserArgumentsAction.RightClick => "right_click",
                ToolsRemoteBrowserArgumentsAction.Screenshot => "screenshot",
                ToolsRemoteBrowserArgumentsAction.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsRemoteBrowserArgumentsAction? ToEnum(string value)
        {
            return value switch
            {
                "cursor_position" => ToolsRemoteBrowserArgumentsAction.CursorPosition,
                "double_click" => ToolsRemoteBrowserArgumentsAction.DoubleClick,
                "key" => ToolsRemoteBrowserArgumentsAction.Key,
                "left_click" => ToolsRemoteBrowserArgumentsAction.LeftClick,
                "left_click_drag" => ToolsRemoteBrowserArgumentsAction.LeftClickDrag,
                "middle_click" => ToolsRemoteBrowserArgumentsAction.MiddleClick,
                "mouse_move" => ToolsRemoteBrowserArgumentsAction.MouseMove,
                "navigate" => ToolsRemoteBrowserArgumentsAction.Navigate,
                "refresh" => ToolsRemoteBrowserArgumentsAction.Refresh,
                "right_click" => ToolsRemoteBrowserArgumentsAction.RightClick,
                "screenshot" => ToolsRemoteBrowserArgumentsAction.Screenshot,
                "type" => ToolsRemoteBrowserArgumentsAction.Type,
                _ => null,
            };
        }
    }
}