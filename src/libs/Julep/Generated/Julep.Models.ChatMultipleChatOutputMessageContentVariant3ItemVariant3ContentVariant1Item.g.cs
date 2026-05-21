
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item
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
        /// <default>global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemTypeJsonConverter))]
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType Type { get; set; } = global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item(
            string text,
            global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType type = global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item" /> class.
        /// </summary>
        public ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item FromText(string text)
        {
            return new ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item
            {
                Text = text,
            };
        }

    }
}