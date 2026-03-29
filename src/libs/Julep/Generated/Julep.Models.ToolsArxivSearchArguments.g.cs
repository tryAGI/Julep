
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Arxiv Search
    /// </summary>
    public sealed partial class ToolsArxivSearchArguments
    {
        /// <summary>
        /// The search query for searching with Arxiv
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The list of Arxiv IDs to search with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public global::System.Collections.Generic.IList<string>? IdList { get; set; }

        /// <summary>
        /// The maximum number of results to return<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public short? MaxResults { get; set; }

        /// <summary>
        /// The download the pdf of the results<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_pdf")]
        public bool? DownloadPdf { get; set; }

        /// <summary>
        /// The sort criterion for the results<br/>
        /// Default Value: relevance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsArxivSearchArgumentsSortByJsonConverter))]
        public global::Julep.ToolsArxivSearchArgumentsSortBy? SortBy { get; set; }

        /// <summary>
        /// The sort order for the results<br/>
        /// Default Value: descending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsArxivSearchArgumentsSortOrderJsonConverter))]
        public global::Julep.ToolsArxivSearchArgumentsSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsArxivSearchArguments" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query for searching with Arxiv
        /// </param>
        /// <param name="idList">
        /// The list of Arxiv IDs to search with
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="downloadPdf">
        /// The download the pdf of the results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The sort criterion for the results<br/>
        /// Default Value: relevance
        /// </param>
        /// <param name="sortOrder">
        /// The sort order for the results<br/>
        /// Default Value: descending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsArxivSearchArguments(
            string query,
            global::System.Collections.Generic.IList<string>? idList,
            short? maxResults,
            bool? downloadPdf,
            global::Julep.ToolsArxivSearchArgumentsSortBy? sortBy,
            global::Julep.ToolsArxivSearchArgumentsSortOrder? sortOrder)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.IdList = idList;
            this.MaxResults = maxResults;
            this.DownloadPdf = downloadPdf;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsArxivSearchArguments" /> class.
        /// </summary>
        public ToolsArxivSearchArguments()
        {
        }
    }
}