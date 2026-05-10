
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesReasoningItem
    {
        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesReasoningItemTypeJsonConverter))]
        public global::Julep.ResponsesReasoningItemType Type { get; set; }

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Reasoning text contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ResponsesReasoningContent> Content { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesReasoningItemStatusJsonConverter))]
        public global::Julep.ResponsesReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoningItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="content">
        /// Reasoning text contents.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::Julep.ResponsesReasoningContent> content,
            global::Julep.ResponsesReasoningItemType type,
            global::Julep.ResponsesReasoningItemStatus? status)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoningItem" /> class.
        /// </summary>
        public ResponsesReasoningItem()
        {
        }

    }
}