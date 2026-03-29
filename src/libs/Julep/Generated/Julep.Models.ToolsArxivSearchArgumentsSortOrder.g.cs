
#nullable enable

namespace Julep
{
    /// <summary>
    /// The sort order for the results<br/>
    /// Default Value: descending
    /// </summary>
    public enum ToolsArxivSearchArgumentsSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsArxivSearchArgumentsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsArxivSearchArgumentsSortOrder value)
        {
            return value switch
            {
                ToolsArxivSearchArgumentsSortOrder.Ascending => "ascending",
                ToolsArxivSearchArgumentsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsArxivSearchArgumentsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ToolsArxivSearchArgumentsSortOrder.Ascending,
                "descending" => ToolsArxivSearchArgumentsSortOrder.Descending,
                _ => null,
            };
        }
    }
}