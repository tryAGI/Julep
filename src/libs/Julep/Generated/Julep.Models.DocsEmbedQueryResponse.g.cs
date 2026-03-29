
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsEmbedQueryResponse
    {
        /// <summary>
        /// The embedded vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Vectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsEmbedQueryResponse" /> class.
        /// </summary>
        /// <param name="vectors">
        /// The embedded vectors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsEmbedQueryResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> vectors)
        {
            this.Vectors = vectors ?? throw new global::System.ArgumentNullException(nameof(vectors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsEmbedQueryResponse" /> class.
        /// </summary>
        public DocsEmbedQueryResponse()
        {
        }
    }
}