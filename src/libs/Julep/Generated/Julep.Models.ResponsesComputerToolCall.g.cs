
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesComputerToolCall
    {
        /// <summary>
        /// The type of the computer call. Always `computer_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesComputerToolCallTypeJsonConverter))]
        public global::Julep.ResponsesComputerToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An identifier used when responding to the tool call with output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The action to perform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ResponsesClick, global::Julep.ResponsesDoubleClick, global::Julep.ResponsesDrag, global::Julep.ResponsesKeyPress, global::Julep.ResponsesMove, global::Julep.ResponsesScreenshot, global::Julep.ResponsesScroll, global::Julep.ResponsesType, global::Julep.ResponsesWait>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.ResponsesClick, global::Julep.ResponsesDoubleClick, global::Julep.ResponsesDrag, global::Julep.ResponsesKeyPress, global::Julep.ResponsesMove, global::Julep.ResponsesScreenshot, global::Julep.ResponsesScroll, global::Julep.ResponsesType, global::Julep.ResponsesWait> Action { get; set; }

        /// <summary>
        /// The pending safety checks for the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_safety_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ResponsesComputerToolCallSafetyCheck> PendingSafetyChecks { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesComputerToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesComputerToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesComputerToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the computer call.
        /// </param>
        /// <param name="callId">
        /// An identifier used when responding to the tool call with output.
        /// </param>
        /// <param name="action">
        /// The action to perform.
        /// </param>
        /// <param name="pendingSafetyChecks">
        /// The pending safety checks for the computer call.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="type">
        /// The type of the computer call. Always `computer_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesComputerToolCall(
            string id,
            string callId,
            global::Julep.AnyOf<global::Julep.ResponsesClick, global::Julep.ResponsesDoubleClick, global::Julep.ResponsesDrag, global::Julep.ResponsesKeyPress, global::Julep.ResponsesMove, global::Julep.ResponsesScreenshot, global::Julep.ResponsesScroll, global::Julep.ResponsesType, global::Julep.ResponsesWait> action,
            global::System.Collections.Generic.IList<global::Julep.ResponsesComputerToolCallSafetyCheck> pendingSafetyChecks,
            global::Julep.ResponsesComputerToolCallStatus status,
            global::Julep.ResponsesComputerToolCallType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Action = action;
            this.PendingSafetyChecks = pendingSafetyChecks ?? throw new global::System.ArgumentNullException(nameof(pendingSafetyChecks));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesComputerToolCall" /> class.
        /// </summary>
        public ResponsesComputerToolCall()
        {
        }

    }
}