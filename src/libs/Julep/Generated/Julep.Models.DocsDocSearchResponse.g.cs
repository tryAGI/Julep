
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsDocSearchResponse
    {
        /// <summary>
        /// The documents that were found
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.DocsDocReference> Docs { get; set; }

        /// <summary>
        /// The time taken to search in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDocSearchResponse" /> class.
        /// </summary>
        /// <param name="docs">
        /// The documents that were found
        /// </param>
        /// <param name="time">
        /// The time taken to search in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsDocSearchResponse(
            global::System.Collections.Generic.IList<global::Julep.DocsDocReference> docs,
            double time)
        {
            this.Docs = docs ?? throw new global::System.ArgumentNullException(nameof(docs));
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDocSearchResponse" /> class.
        /// </summary>
        public DocsDocSearchResponse()
        {
        }
    }
}