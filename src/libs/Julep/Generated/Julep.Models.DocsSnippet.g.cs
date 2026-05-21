
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsSnippet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsSnippet" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="content"></param>
        /// <param name="embedding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsSnippet(
            int index,
            string content,
            global::System.Collections.Generic.IList<double>? embedding)
        {
            this.Index = index;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Embedding = embedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsSnippet" /> class.
        /// </summary>
        public DocsSnippet()
        {
        }

    }
}