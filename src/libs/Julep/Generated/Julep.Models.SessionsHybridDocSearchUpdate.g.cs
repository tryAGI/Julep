
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsHybridDocSearchUpdate
    {
        /// <summary>
        /// The mode to use for the search.<br/>
        /// Default Value: hybrid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.SessionsHybridDocSearchUpdateModeJsonConverter))]
        public global::Julep.SessionsHybridDocSearchUpdateMode? Mode { get; set; }

        /// <summary>
        /// The confidence cutoff level<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The weight to apply to BM25 vs Vector search results. 0 =&gt; pure BM25; 1 =&gt; pure vector;<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha")]
        public double? Alpha { get; set; }

        /// <summary>
        /// MMR Strength (mmr_strength = 1 - mmr_lambda)<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mmr_strength")]
        public double? MmrStrength { get; set; }

        /// <summary>
        /// The trigram_similarity_threshold cutoff level<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigram_similarity_threshold")]
        public double? TrigramSimilarityThreshold { get; set; }

        /// <summary>
        /// The k_multiplier cutoff level to control how many intermediate results to fetch before final scoring<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k_multiplier")]
        public int? KMultiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsHybridDocSearchUpdate" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode to use for the search.<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="confidence">
        /// The confidence cutoff level<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="alpha">
        /// The weight to apply to BM25 vs Vector search results. 0 =&gt; pure BM25; 1 =&gt; pure vector;<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="mmrStrength">
        /// MMR Strength (mmr_strength = 1 - mmr_lambda)<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="trigramSimilarityThreshold">
        /// The trigram_similarity_threshold cutoff level<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="kMultiplier">
        /// The k_multiplier cutoff level to control how many intermediate results to fetch before final scoring<br/>
        /// Default Value: 7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsHybridDocSearchUpdate(
            global::Julep.SessionsHybridDocSearchUpdateMode? mode,
            double? confidence,
            double? alpha,
            double? mmrStrength,
            double? trigramSimilarityThreshold,
            int? kMultiplier)
        {
            this.Mode = mode;
            this.Confidence = confidence;
            this.Alpha = alpha;
            this.MmrStrength = mmrStrength;
            this.TrigramSimilarityThreshold = trigramSimilarityThreshold;
            this.KMultiplier = kMultiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsHybridDocSearchUpdate" /> class.
        /// </summary>
        public SessionsHybridDocSearchUpdate()
        {
        }
    }
}