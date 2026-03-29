
#nullable enable

namespace Julep
{
    /// <summary>
    /// The sort criterion for the results<br/>
    /// Default Value: relevance
    /// </summary>
    public enum ToolsArxivSearchArgumentsUpdateSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        LastUpdatedDate,
        /// <summary>
        /// 
        /// </summary>
        Relevance,
        /// <summary>
        /// 
        /// </summary>
        SubmittedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsArxivSearchArgumentsUpdateSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsArxivSearchArgumentsUpdateSortBy value)
        {
            return value switch
            {
                ToolsArxivSearchArgumentsUpdateSortBy.LastUpdatedDate => "lastUpdatedDate",
                ToolsArxivSearchArgumentsUpdateSortBy.Relevance => "relevance",
                ToolsArxivSearchArgumentsUpdateSortBy.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsArxivSearchArgumentsUpdateSortBy? ToEnum(string value)
        {
            return value switch
            {
                "lastUpdatedDate" => ToolsArxivSearchArgumentsUpdateSortBy.LastUpdatedDate,
                "relevance" => ToolsArxivSearchArgumentsUpdateSortBy.Relevance,
                "submittedDate" => ToolsArxivSearchArgumentsUpdateSortBy.SubmittedDate,
                _ => null,
            };
        }
    }
}