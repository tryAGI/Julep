
#nullable enable

namespace Julep
{
    /// <summary>
    /// The action to perform
    /// </summary>
    public enum ToolsRemoteBrowserArgumentsUpdateAction
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
    public static class ToolsRemoteBrowserArgumentsUpdateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsRemoteBrowserArgumentsUpdateAction value)
        {
            return value switch
            {
                ToolsRemoteBrowserArgumentsUpdateAction.CursorPosition => "cursor_position",
                ToolsRemoteBrowserArgumentsUpdateAction.DoubleClick => "double_click",
                ToolsRemoteBrowserArgumentsUpdateAction.Key => "key",
                ToolsRemoteBrowserArgumentsUpdateAction.LeftClick => "left_click",
                ToolsRemoteBrowserArgumentsUpdateAction.LeftClickDrag => "left_click_drag",
                ToolsRemoteBrowserArgumentsUpdateAction.MiddleClick => "middle_click",
                ToolsRemoteBrowserArgumentsUpdateAction.MouseMove => "mouse_move",
                ToolsRemoteBrowserArgumentsUpdateAction.Navigate => "navigate",
                ToolsRemoteBrowserArgumentsUpdateAction.Refresh => "refresh",
                ToolsRemoteBrowserArgumentsUpdateAction.RightClick => "right_click",
                ToolsRemoteBrowserArgumentsUpdateAction.Screenshot => "screenshot",
                ToolsRemoteBrowserArgumentsUpdateAction.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsRemoteBrowserArgumentsUpdateAction? ToEnum(string value)
        {
            return value switch
            {
                "cursor_position" => ToolsRemoteBrowserArgumentsUpdateAction.CursorPosition,
                "double_click" => ToolsRemoteBrowserArgumentsUpdateAction.DoubleClick,
                "key" => ToolsRemoteBrowserArgumentsUpdateAction.Key,
                "left_click" => ToolsRemoteBrowserArgumentsUpdateAction.LeftClick,
                "left_click_drag" => ToolsRemoteBrowserArgumentsUpdateAction.LeftClickDrag,
                "middle_click" => ToolsRemoteBrowserArgumentsUpdateAction.MiddleClick,
                "mouse_move" => ToolsRemoteBrowserArgumentsUpdateAction.MouseMove,
                "navigate" => ToolsRemoteBrowserArgumentsUpdateAction.Navigate,
                "refresh" => ToolsRemoteBrowserArgumentsUpdateAction.Refresh,
                "right_click" => ToolsRemoteBrowserArgumentsUpdateAction.RightClick,
                "screenshot" => ToolsRemoteBrowserArgumentsUpdateAction.Screenshot,
                "type" => ToolsRemoteBrowserArgumentsUpdateAction.Type,
                _ => null,
            };
        }
    }
}