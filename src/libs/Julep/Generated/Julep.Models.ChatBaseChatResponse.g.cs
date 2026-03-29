
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatBaseChatResponse
    {
        /// <summary>
        /// Usage statistics for the completion request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Julep.ChatCompletionUsage? Usage { get; set; }

        /// <summary>
        /// Background job IDs that may have been spawned from this interaction.<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::System.Collections.Generic.IList<global::System.Guid> Jobs { get; set; } = default!;

        /// <summary>
        /// Documents referenced for this request (for citation purposes).<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public global::System.Collections.Generic.IList<global::Julep.DocsDocReference> Docs { get; set; } = default!;

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBaseChatResponse" /> class.
        /// </summary>
        /// <param name="usage">
        /// Usage statistics for the completion request
        /// </param>
        /// <param name="jobs">
        /// Background job IDs that may have been spawned from this interaction.<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
        /// <param name="docs">
        /// Documents referenced for this request (for citation purposes).<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatBaseChatResponse(
            global::Julep.ChatCompletionUsage? usage,
            global::System.Collections.Generic.IList<global::System.Guid> jobs = default!,
            global::System.Collections.Generic.IList<global::Julep.DocsDocReference> docs = default!,
            global::System.DateTime createdAt = default!,
            global::System.Guid id = default!)
        {
            this.Usage = usage;
            this.Jobs = jobs;
            this.Docs = docs;
            this.CreatedAt = createdAt;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBaseChatResponse" /> class.
        /// </summary>
        public ChatBaseChatResponse()
        {
        }
    }
}