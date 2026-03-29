
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatChatInputData
    {
        /// <summary>
        /// A list of new input messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ChatChatInputDataMessage> Messages { get; set; }

        /// <summary>
        /// (Advanced) List of tools that are provided in addition to agent's default set of tools.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Julep.ToolsCreateToolRequest>? Tools { get; set; }

        /// <summary>
        /// Can be one of existing tools given to the agent earlier or the ones provided in this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ChatChatInputDataToolChoice?, global::Julep.ToolsNamedToolChoice>))]
        public global::Julep.AnyOf<global::Julep.ChatChatInputDataToolChoice?, global::Julep.ToolsNamedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChatInputData" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of new input messages comprising the conversation so far.
        /// </param>
        /// <param name="tools">
        /// (Advanced) List of tools that are provided in addition to agent's default set of tools.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolChoice">
        /// Can be one of existing tools given to the agent earlier or the ones provided in this request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatChatInputData(
            global::System.Collections.Generic.IList<global::Julep.ChatChatInputDataMessage> messages,
            global::System.Collections.Generic.IList<global::Julep.ToolsCreateToolRequest>? tools,
            global::Julep.AnyOf<global::Julep.ChatChatInputDataToolChoice?, global::Julep.ToolsNamedToolChoice>? toolChoice)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
            this.ToolChoice = toolChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChatInputData" /> class.
        /// </summary>
        public ChatChatInputData()
        {
        }
    }
}