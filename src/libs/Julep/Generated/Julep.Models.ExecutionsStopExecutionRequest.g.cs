
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionsStopExecutionRequest
    {
        /// <summary>
        /// Default Value: cancelled
        /// </summary>
        /// <default>global::Julep.ExecutionsStopExecutionRequestStatus.Cancelled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ExecutionsStopExecutionRequestStatusJsonConverter))]
        public global::Julep.ExecutionsStopExecutionRequestStatus Status { get; set; } = global::Julep.ExecutionsStopExecutionRequestStatus.Cancelled;

        /// <summary>
        /// The reason for stopping the execution<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsStopExecutionRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason for stopping the execution<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Default Value: cancelled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsStopExecutionRequest(
            string? reason,
            global::Julep.ExecutionsStopExecutionRequestStatus status = global::Julep.ExecutionsStopExecutionRequestStatus.Cancelled)
        {
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsStopExecutionRequest" /> class.
        /// </summary>
        public ExecutionsStopExecutionRequest()
        {
        }
    }
}