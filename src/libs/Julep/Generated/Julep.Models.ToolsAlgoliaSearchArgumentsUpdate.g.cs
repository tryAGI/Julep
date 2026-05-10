
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Algolia Search
    /// </summary>
    public sealed partial class ToolsAlgoliaSearchArgumentsUpdate
    {
        /// <summary>
        /// The index name to search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// The query to search for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Optional attributes to retrieve
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes_to_retrieve")]
        public global::System.Collections.Generic.IList<string>? AttributesToRetrieve { get; set; }

        /// <summary>
        /// Maximum number of hits to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits_per_page")]
        public int? HitsPerPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaSearchArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="indexName">
        /// The index name to search
        /// </param>
        /// <param name="query">
        /// The query to search for
        /// </param>
        /// <param name="attributesToRetrieve">
        /// Optional attributes to retrieve
        /// </param>
        /// <param name="hitsPerPage">
        /// Maximum number of hits to return<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsAlgoliaSearchArgumentsUpdate(
            string? indexName,
            string? query,
            global::System.Collections.Generic.IList<string>? attributesToRetrieve,
            int? hitsPerPage)
        {
            this.IndexName = indexName;
            this.Query = query;
            this.AttributesToRetrieve = attributesToRetrieve;
            this.HitsPerPage = hitsPerPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaSearchArgumentsUpdate" /> class.
        /// </summary>
        public ToolsAlgoliaSearchArgumentsUpdate()
        {
        }

    }
}