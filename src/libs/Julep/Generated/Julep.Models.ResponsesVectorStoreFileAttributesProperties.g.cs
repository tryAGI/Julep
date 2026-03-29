
#nullable enable

namespace Julep
{
    /// <summary>
    /// Key-value pairs where keys are strings with max length 64 and values are strings with max length 512, booleans, or numbers.
    /// </summary>
    public sealed partial class ResponsesVectorStoreFileAttributesProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}