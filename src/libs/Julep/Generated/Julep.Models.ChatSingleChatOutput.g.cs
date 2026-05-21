
#nullable enable

namespace Julep
{
    /// <summary>
    /// The output returned by the model. Note that, depending on the model provider, they might return more than one message.
    /// </summary>
    public sealed partial class ChatSingleChatOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ChatSingleChatOutputMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSingleChatOutput" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSingleChatOutput(
            global::Julep.ChatSingleChatOutputMessage message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSingleChatOutput" /> class.
        /// </summary>
        public ChatSingleChatOutput()
        {
        }

    }
}