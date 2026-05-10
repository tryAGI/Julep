
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesInputMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesInputMessageTypeJsonConverter))]
        public global::Julep.ResponsesInputMessageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesMessageStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="status"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesInputMessage(
            global::Julep.ResponsesMessageRole role,
            global::Julep.ResponsesMessageStatus status,
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>> content,
            global::Julep.ResponsesInputMessageType type)
        {
            this.Type = type;
            this.Role = role;
            this.Status = status;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputMessage" /> class.
        /// </summary>
        public ResponsesInputMessage()
        {
        }

    }
}