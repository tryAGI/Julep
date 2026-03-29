
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsTextOnlyDocSearchUpdate
    {
        /// <summary>
        /// The mode to use for the search.<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.SessionsTextOnlyDocSearchUpdateModeJsonConverter))]
        public global::Julep.SessionsTextOnlyDocSearchUpdateMode? Mode { get; set; }

        /// <summary>
        /// The trigram_similarity_threshold cutoff level<br/>
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
        /// Initializes a new instance of the <see cref="SessionsTextOnlyDocSearchUpdate" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode to use for the search.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="trigramSimilarityThreshold">
        /// The trigram_similarity_threshold cutoff level<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsTextOnlyDocSearchUpdate(
            global::Julep.SessionsTextOnlyDocSearchUpdateMode? mode,
            double? trigramSimilarityThreshold)
        {
            this.Mode = mode;
            this.TrigramSimilarityThreshold = trigramSimilarityThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsTextOnlyDocSearchUpdate" /> class.
        /// </summary>
        public SessionsTextOnlyDocSearchUpdate()
        {
        }
    }
}