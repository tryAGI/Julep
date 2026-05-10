
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesComputerToolCallOutput
    {
        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesComputerToolCallOutputTypeJsonConverter))]
        public global::Julep.ResponsesComputerToolCallOutputType Type { get; set; }

        /// <summary>
        /// The ID of the computer tool call output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the computer tool call that produced the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The safety checks reported by the API that have been acknowledged by the developer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::Julep.ResponsesComputerToolCallSafetyCheck>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// The output screenshot image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesComputerScreenshotImage Output { get; set; }

        /// <summary>
        /// The status of the message input. One of `in_progress`, `completed`, or `incomplete`. Populated when input items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesMessageStatusJsonConverter))]
        public global::Julep.ResponsesMessageStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesComputerToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="output">
        /// The output screenshot image.
        /// </param>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.
        /// </param>
        /// <param name="id">
        /// The ID of the computer tool call output.
        /// </param>
        /// <param name="acknowledgedSafetyChecks">
        /// The safety checks reported by the API that have been acknowledged by the developer.
        /// </param>
        /// <param name="status">
        /// The status of the message input. One of `in_progress`, `completed`, or `incomplete`. Populated when input items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesComputerToolCallOutput(
            string callId,
            global::Julep.ResponsesComputerScreenshotImage output,
            global::Julep.ResponsesComputerToolCallOutputType type,
            string? id,
            global::System.Collections.Generic.IList<global::Julep.ResponsesComputerToolCallSafetyCheck>? acknowledgedSafetyChecks,
            global::Julep.ResponsesMessageStatus? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesComputerToolCallOutput" /> class.
        /// </summary>
        public ResponsesComputerToolCallOutput()
        {
        }

    }
}