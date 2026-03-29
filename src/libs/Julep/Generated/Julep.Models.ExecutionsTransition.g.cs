
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionsTransition
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public global::System.Guid ExecutionId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public global::Julep.ExecutionsTransitionTarget Current { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public global::Julep.ExecutionsTransitionTarget? Next { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_label")]
        public string? StepLabel { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsTransition" /> class.
        /// </summary>
        /// <param name="next">
        /// Included only in responses
        /// </param>
        /// <param name="stepLabel">
        /// Included only in responses
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="executionId">
        /// Included only in responses
        /// </param>
        /// <param name="current">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsTransition(
            global::Julep.ExecutionsTransitionTarget? next,
            string? stepLabel,
            object? metadata,
            global::System.Guid executionId = default!,
            global::Julep.ExecutionsTransitionTarget current = default!,
            global::System.Guid id = default!)
        {
            this.ExecutionId = executionId;
            this.Current = current;
            this.Next = next;
            this.StepLabel = stepLabel;
            this.Id = id;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsTransition" /> class.
        /// </summary>
        public ExecutionsTransition()
        {
        }
    }
}