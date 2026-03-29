
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesFileSearchTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesFileSearchToolTypeJsonConverter))]
        public global::Julep.ResponsesFileSearchToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::Julep.ResponsesFileSearchToolRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VectorStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFileSearchTool" /> class.
        /// </summary>
        /// <param name="vectorStoreIds"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="maxNumResults"></param>
        /// <param name="rankingOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesFileSearchTool(
            global::System.Collections.Generic.IList<string> vectorStoreIds,
            global::Julep.ResponsesFileSearchToolType type,
            object? filters,
            int? maxNumResults,
            global::Julep.ResponsesFileSearchToolRankingOptions? rankingOptions)
        {
            this.Type = type;
            this.Filters = filters;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
            this.VectorStoreIds = vectorStoreIds ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFileSearchTool" /> class.
        /// </summary>
        public ResponsesFileSearchTool()
        {
        }
    }
}