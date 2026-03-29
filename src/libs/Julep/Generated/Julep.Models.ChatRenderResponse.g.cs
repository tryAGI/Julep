
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRenderResponse
    {
        /// <summary>
        /// Documents referenced for this request (for citation purposes).<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public global::System.Collections.Generic.IList<global::Julep.DocsDocReference> Docs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRenderResponse" /> class.
        /// </summary>
        /// <param name="docs">
        /// Documents referenced for this request (for citation purposes).<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRenderResponse(
            global::System.Collections.Generic.IList<global::Julep.DocsDocReference> docs = default!)
        {
            this.Docs = docs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRenderResponse" /> class.
        /// </summary>
        public ChatRenderResponse()
        {
        }
    }
}