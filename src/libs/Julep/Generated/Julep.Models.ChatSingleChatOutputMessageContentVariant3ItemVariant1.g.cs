
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSingleChatOutputMessageContentVariant3ItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1Type.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ChatSingleChatOutputMessageContentVariant3ItemVariant1TypeJsonConverter))]
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1Type Type { get; set; } = global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1Type.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSingleChatOutputMessageContentVariant3ItemVariant1" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSingleChatOutputMessageContentVariant3ItemVariant1(
            string text,
            global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1Type type = global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1Type.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSingleChatOutputMessageContentVariant3ItemVariant1" /> class.
        /// </summary>
        public ChatSingleChatOutputMessageContentVariant3ItemVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatSingleChatOutputMessageContentVariant3ItemVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatSingleChatOutputMessageContentVariant3ItemVariant1 FromText(string text)
        {
            return new ChatSingleChatOutputMessageContentVariant3ItemVariant1
            {
                Text = text,
            };
        }

    }
}