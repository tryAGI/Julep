
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesEasyInputMessage
    {
        /// <summary>
        /// The role of the message input. One of `user`, `assistant`, `system`, or `developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesMessageRole Role { get; set; }

        /// <summary>
        /// Text, image, or audio input to the model, used to generate a response. Can also contain previous assistant responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>> Content { get; set; }

        /// <summary>
        /// The type of the message input. Always `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesEasyInputMessageTypeJsonConverter))]
        public global::Julep.ResponsesEasyInputMessageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesEasyInputMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message input. One of `user`, `assistant`, `system`, or `developer`.
        /// </param>
        /// <param name="content">
        /// Text, image, or audio input to the model, used to generate a response. Can also contain previous assistant responses.
        /// </param>
        /// <param name="type">
        /// The type of the message input. Always `message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesEasyInputMessage(
            global::Julep.ResponsesMessageRole role,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>> content,
            global::Julep.ResponsesEasyInputMessageType type)
        {
            this.Role = role;
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesEasyInputMessage" /> class.
        /// </summary>
        public ResponsesEasyInputMessage()
        {
        }
    }
}