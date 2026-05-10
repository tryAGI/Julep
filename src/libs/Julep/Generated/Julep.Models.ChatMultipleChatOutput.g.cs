
#nullable enable

namespace Julep
{
    /// <summary>
    /// The output returned by the model. Note that, depending on the model provider, they might return more than one message.
    /// </summary>
    public sealed partial class ChatMultipleChatOutput
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Julep.ChatMultipleChatOutputMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMultipleChatOutput" /> class.
        /// </summary>
        /// <param name="messages">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMultipleChatOutput(
            global::System.Collections.Generic.IList<global::Julep.ChatMultipleChatOutputMessage> messages = default!)
        {
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMultipleChatOutput" /> class.
        /// </summary>
        public ChatMultipleChatOutput()
        {
        }

    }
}