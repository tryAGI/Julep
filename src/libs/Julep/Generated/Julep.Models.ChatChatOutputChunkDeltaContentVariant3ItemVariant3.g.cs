
#nullable enable

namespace Julep
{
    /// <summary>
    /// Anthropic image content part
    /// </summary>
    public sealed partial class ChatChatOutputChunkDeltaContentVariant3ItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: tool_result
        /// </summary>
        /// <default>global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3Type.ToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ChatChatOutputChunkDeltaContentVariant3ItemVariant3TypeJsonConverter))]
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3Type Type { get; set; } = global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3Type.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1Item>, global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1Item>, global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChatOutputChunkDeltaContentVariant3ItemVariant3" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatChatOutputChunkDeltaContentVariant3ItemVariant3(
            string toolUseId,
            global::Julep.AnyOf<global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1Item>, global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2Item>> content,
            global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3Type type = global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3Type.ToolResult)
        {
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChatOutputChunkDeltaContentVariant3ItemVariant3" /> class.
        /// </summary>
        public ChatChatOutputChunkDeltaContentVariant3ItemVariant3()
        {
        }
    }
}