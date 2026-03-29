
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsVectorDocSearchRequest
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
        /// Vector to use in the search. Must be the same dimensions as the embedding model or else an error will be thrown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Vector { get; set; }

        /// <summary>
        /// The confidence cutoff level<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// MMR Strength (mmr_strength = 1 - mmr_lambda)<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mmr_strength")]
        public double? MmrStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsVectorDocSearchRequest" /> class.
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
        /// <param name="vector">
        /// Vector to use in the search. Must be the same dimensions as the embedding model or else an error will be thrown.
        /// </param>
        /// <param name="confidence">
        /// The confidence cutoff level<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="mmrStrength">
        /// MMR Strength (mmr_strength = 1 - mmr_lambda)<br/>
        /// Default Value: 0.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsVectorDocSearchRequest(
            int limit,
            object metadataFilter,
            bool includeEmbeddings,
            global::System.Collections.Generic.IList<double> vector,
            double confidence,
            double? mmrStrength)
        {
            this.Limit = limit;
            this.MetadataFilter = metadataFilter ?? throw new global::System.ArgumentNullException(nameof(metadataFilter));
            this.IncludeEmbeddings = includeEmbeddings;
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
            this.Confidence = confidence;
            this.MmrStrength = mmrStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsVectorDocSearchRequest" /> class.
        /// </summary>
        public DocsVectorDocSearchRequest()
        {
        }
    }
}