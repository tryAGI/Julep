
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for patching a project
    /// </summary>
    public sealed partial class ProjectsPatchProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Canonical name of the project (unique per developer)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// Display name of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsPatchProjectRequest" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="canonicalName">
        /// Canonical name of the project (unique per developer)
        /// </param>
        /// <param name="name">
        /// Display name of the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsPatchProjectRequest(
            object? metadata,
            string? canonicalName,
            string? name)
        {
            this.Metadata = metadata;
            this.CanonicalName = canonicalName;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsPatchProjectRequest" /> class.
        /// </summary>
        public ProjectsPatchProjectRequest()
        {
        }
    }
}