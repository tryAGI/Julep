
#nullable enable

namespace Julep
{
    /// <summary>
    /// The sort order for the results<br/>
    /// Default Value: descending
    /// </summary>
    public enum ToolsArxivSearchArgumentsUpdateSortOrder
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
    public static class ToolsArxivSearchArgumentsUpdateSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsArxivSearchArgumentsUpdateSortOrder value)
        {
            return value switch
            {
                ToolsArxivSearchArgumentsUpdateSortOrder.Ascending => "ascending",
                ToolsArxivSearchArgumentsUpdateSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsArxivSearchArgumentsUpdateSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ToolsArxivSearchArgumentsUpdateSortOrder.Ascending,
                "descending" => ToolsArxivSearchArgumentsUpdateSortOrder.Descending,
                _ => null,
            };
        }
    }
}