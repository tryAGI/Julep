
#nullable enable

namespace Julep
{
    /// <summary>
    /// The command to run
    /// </summary>
    public enum ToolsChosenTextEditor20241022Command
    {
        /// <summary>
        /// 
        /// </summary>
        Insert,
        /// <summary>
        /// 
        /// </summary>
        StrReplace,
        /// <summary>
        /// 
        /// </summary>
        UndoEdit,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsChosenTextEditor20241022CommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsChosenTextEditor20241022Command value)
        {
            return value switch
            {
                ToolsChosenTextEditor20241022Command.Insert => "insert",
                ToolsChosenTextEditor20241022Command.StrReplace => "str_replace",
                ToolsChosenTextEditor20241022Command.UndoEdit => "undo_edit",
                ToolsChosenTextEditor20241022Command.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsChosenTextEditor20241022Command? ToEnum(string value)
        {
            return value switch
            {
                "insert" => ToolsChosenTextEditor20241022Command.Insert,
                "str_replace" => ToolsChosenTextEditor20241022Command.StrReplace,
                "undo_edit" => ToolsChosenTextEditor20241022Command.UndoEdit,
                "view" => ToolsChosenTextEditor20241022Command.View,
                _ => null,
            };
        }
    }
}