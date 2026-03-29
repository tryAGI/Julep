
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsBaseDocSearch
    {
        /// <summary>
        /// The limit of documents to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The language to be used for text-only search. Support for other languages coming soon.<br/>
        /// Default Value: en-US
        /// </summary>
        /// <default>"en-US"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lang { get; set; } = "en-US";

        /// <summary>
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object MetadataFilter { get; set; }

        /// <summary>
        /// The number of search messages to use for the search.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_search_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumSearchMessages { get; set; }

        /// <summary>
        /// The maximum query length to use for the search.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_query_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxQueryLength { get; set; }

        /// <summary>
        /// Whether to include embeddings in the response<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeEmbeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsBaseDocSearch" /> class.
        /// </summary>
        /// <param name="limit">
        /// The limit of documents to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="lang">
        /// The language to be used for text-only search. Support for other languages coming soon.<br/>
        /// Default Value: en-US
        /// </param>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="numSearchMessages">
        /// The number of search messages to use for the search.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="maxQueryLength">
        /// The maximum query length to use for the search.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="includeEmbeddings">
        /// Whether to include embeddings in the response<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsBaseDocSearch(
            int limit,
            string lang,
            object metadataFilter,
            int numSearchMessages,
            int maxQueryLength,
            bool includeEmbeddings)
        {
            this.Limit = limit;
            this.Lang = lang ?? throw new global::System.ArgumentNullException(nameof(lang));
            this.MetadataFilter = metadataFilter ?? throw new global::System.ArgumentNullException(nameof(metadataFilter));
            this.NumSearchMessages = numSearchMessages;
            this.MaxQueryLength = maxQueryLength;
            this.IncludeEmbeddings = includeEmbeddings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsBaseDocSearch" /> class.
        /// </summary>
        public SessionsBaseDocSearch()
        {
        }
    }
}