
#nullable enable

namespace Julep
{
    /// <summary>
    /// Set of key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format, and querying for objects via API or the dashboard. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters, booleans, or numbers.
    /// </summary>
    public sealed partial class ResponsesVectorStoreFileAttributes
    {
        /// <summary>
        /// Key-value pairs where keys are strings with max length 64 and values are strings with max length 512, booleans, or numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesVectorStoreFileAttributes" /> class.
        /// </summary>
        /// <param name="properties">
        /// Key-value pairs where keys are strings with max length 64 and values are strings with max length 512, booleans, or numbers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesVectorStoreFileAttributes(
            object properties)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesVectorStoreFileAttributes" /> class.
        /// </summary>
        public ResponsesVectorStoreFileAttributes()
        {
        }
    }
}