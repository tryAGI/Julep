
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Wikipedia Search
    /// </summary>
    public sealed partial class ToolsWikipediaSearchArguments
    {
        /// <summary>
        /// The search query string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Maximum number of documents to load<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("load_max_docs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte LoadMaxDocs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWikipediaSearchArguments" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string
        /// </param>
        /// <param name="loadMaxDocs">
        /// Maximum number of documents to load<br/>
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWikipediaSearchArguments(
            string query,
            byte loadMaxDocs)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.LoadMaxDocs = loadMaxDocs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWikipediaSearchArguments" /> class.
        /// </summary>
        public ToolsWikipediaSearchArguments()
        {
        }

    }
}