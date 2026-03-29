
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for creating an execution
    /// </summary>
    public sealed partial class ExecutionsCreateExecutionRequest
    {
        /// <summary>
        /// The input to the execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The output of the execution if it succeeded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// The error of the execution if it failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The number of transitions in this execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_count")]
        public byte? TransitionCount { get; set; }

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
        /// Initializes a new instance of the <see cref="ExecutionsCreateExecutionRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to the execution
        /// </param>
        /// <param name="output">
        /// The output of the execution if it succeeded
        /// </param>
        /// <param name="error">
        /// The error of the execution if it failed
        /// </param>
        /// <param name="transitionCount">
        /// The number of transitions in this execution
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsCreateExecutionRequest(
            object input,
            object? output,
            string? error,
            byte? transitionCount,
            object? metadata)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output;
            this.Error = error;
            this.TransitionCount = transitionCount;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsCreateExecutionRequest" /> class.
        /// </summary>
        public ExecutionsCreateExecutionRequest()
        {
        }
    }
}