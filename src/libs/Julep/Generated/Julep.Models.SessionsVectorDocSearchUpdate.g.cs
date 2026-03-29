
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsVectorDocSearchUpdate
    {
        /// <summary>
        /// The mode to use for the search.<br/>
        /// Default Value: vector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.SessionsVectorDocSearchUpdateModeJsonConverter))]
        public global::Julep.SessionsVectorDocSearchUpdateMode? Mode { get; set; }

        /// <summary>
        /// The confidence cutoff level<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionsVectorDocSearchUpdate" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode to use for the search.<br/>
        /// Default Value: vector
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
        public SessionsVectorDocSearchUpdate(
            global::Julep.SessionsVectorDocSearchUpdateMode? mode,
            double? confidence,
            double? mmrStrength)
        {
            this.Mode = mode;
            this.Confidence = confidence;
            this.MmrStrength = mmrStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsVectorDocSearchUpdate" /> class.
        /// </summary>
        public SessionsVectorDocSearchUpdate()
        {
        }
    }
}