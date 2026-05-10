
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsTextOnlyDocSearchRequest
    {
        /// <summary>
        /// The limit of documents to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object MetadataFilter { get; set; }

        /// <summary>
        /// Whether to include embeddings in the response<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeEmbeddings { get; set; }

        /// <summary>
        /// Text to use in the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The language to be used for text search. Support for other languages coming soon.<br/>
        /// Default Value: en-US
        /// </summary>
        /// <default>"en-US"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lang { get; set; } = "en-US";

        /// <summary>
        /// Trigram similarity threshold for fuzzy matching. Set to null to disable trigram search.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigram_similarity_threshold")]
        public double? TrigramSimilarityThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsTextOnlyDocSearchRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// The limit of documents to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="includeEmbeddings">
        /// Whether to include embeddings in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="text">
        /// Text to use in the search
        /// </param>
        /// <param name="lang">
        /// The language to be used for text search. Support for other languages coming soon.<br/>
        /// Default Value: en-US
        /// </param>
        /// <param name="trigramSimilarityThreshold">
        /// Trigram similarity threshold for fuzzy matching. Set to null to disable trigram search.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsTextOnlyDocSearchRequest(
            int limit,
            object metadataFilter,
            bool includeEmbeddings,
            string text,
            string lang,
            double? trigramSimilarityThreshold)
        {
            this.Limit = limit;
            this.MetadataFilter = metadataFilter ?? throw new global::System.ArgumentNullException(nameof(metadataFilter));
            this.IncludeEmbeddings = includeEmbeddings;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Lang = lang ?? throw new global::System.ArgumentNullException(nameof(lang));
            this.TrigramSimilarityThreshold = trigramSimilarityThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsTextOnlyDocSearchRequest" /> class.
        /// </summary>
        public DocsTextOnlyDocSearchRequest()
        {
        }

    }
}