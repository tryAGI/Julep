
#nullable enable

namespace Julep
{
    /// <summary>
    /// The sort criterion for the results<br/>
    /// Default Value: relevance
    /// </summary>
    public enum ToolsArxivSearchArgumentsSortBy
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
    public static class ToolsArxivSearchArgumentsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsArxivSearchArgumentsSortBy value)
        {
            return value switch
            {
                ToolsArxivSearchArgumentsSortBy.LastUpdatedDate => "lastUpdatedDate",
                ToolsArxivSearchArgumentsSortBy.Relevance => "relevance",
                ToolsArxivSearchArgumentsSortBy.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsArxivSearchArgumentsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "lastUpdatedDate" => ToolsArxivSearchArgumentsSortBy.LastUpdatedDate,
                "relevance" => ToolsArxivSearchArgumentsSortBy.Relevance,
                "submittedDate" => ToolsArxivSearchArgumentsSortBy.SubmittedDate,
                _ => null,
            };
        }
    }
}