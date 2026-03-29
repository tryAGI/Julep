
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: text_editor_20241022
    /// </summary>
    public enum ToolsTextEditor20241022DefUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsTextEditor20241022DefUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsTextEditor20241022DefUpdateType value)
        {
            return value switch
            {
                ToolsTextEditor20241022DefUpdateType.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsTextEditor20241022DefUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20241022" => ToolsTextEditor20241022DefUpdateType.TextEditor20241022,
                _ => null,
            };
        }
    }
}