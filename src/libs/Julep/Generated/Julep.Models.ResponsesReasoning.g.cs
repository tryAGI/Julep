
#nullable enable

namespace Julep
{
    /// <summary>
    /// Reasoning configuration options for o-series models.
    /// </summary>
    public sealed partial class ResponsesReasoning
    {
        /// <summary>
        /// Constraint effort on reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesReasoningEffortJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesReasoningEffort Effort { get; set; }

        /// <summary>
        /// A summary of the reasoning performed by the model. This can be useful for debugging and understanding the model's reasoning process. One of `concise` or `detailed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesReasoningGenerateSummaryJsonConverter))]
        public global::Julep.ResponsesReasoningGenerateSummary? GenerateSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constraint effort on reasoning models.
        /// </param>
        /// <param name="generateSummary">
        /// A summary of the reasoning performed by the model. This can be useful for debugging and understanding the model's reasoning process. One of `concise` or `detailed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesReasoning(
            global::Julep.ResponsesReasoningEffort effort,
            global::Julep.ResponsesReasoningGenerateSummary? generateSummary)
        {
            this.Effort = effort;
            this.GenerateSummary = generateSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoning" /> class.
        /// </summary>
        public ResponsesReasoning()
        {
        }
    }
}