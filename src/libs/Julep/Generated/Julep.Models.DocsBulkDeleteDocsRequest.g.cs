
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsBulkDeleteDocsRequest
    {
        /// <summary>
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object MetadataFilter { get; set; }

        /// <summary>
        /// Delete all docs<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DeleteAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsBulkDeleteDocsRequest" /> class.
        /// </summary>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="deleteAll">
        /// Delete all docs<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsBulkDeleteDocsRequest(
            object metadataFilter,
            bool deleteAll)
        {
            this.MetadataFilter = metadataFilter ?? throw new global::System.ArgumentNullException(nameof(metadataFilter));
            this.DeleteAll = deleteAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsBulkDeleteDocsRequest" /> class.
        /// </summary>
        public DocsBulkDeleteDocsRequest()
        {
        }

    }
}