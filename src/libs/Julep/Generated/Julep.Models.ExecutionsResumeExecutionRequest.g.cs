
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionsResumeExecutionRequest
    {
        /// <summary>
        /// Default Value: running
        /// </summary>
        /// <default>global::Julep.ExecutionsResumeExecutionRequestStatus.Running</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ExecutionsResumeExecutionRequestStatusJsonConverter))]
        public global::Julep.ExecutionsResumeExecutionRequestStatus Status { get; set; } = global::Julep.ExecutionsResumeExecutionRequestStatus.Running;

        /// <summary>
        /// The input to resume the execution with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsResumeExecutionRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to resume the execution with
        /// </param>
        /// <param name="status">
        /// Default Value: running
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsResumeExecutionRequest(
            object? input,
            global::Julep.ExecutionsResumeExecutionRequestStatus status = global::Julep.ExecutionsResumeExecutionRequestStatus.Running)
        {
            this.Status = status;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsResumeExecutionRequest" /> class.
        /// </summary>
        public ExecutionsResumeExecutionRequest()
        {
        }
    }
}