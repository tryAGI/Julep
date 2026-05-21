
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for updating a project
    /// </summary>
    public sealed partial class ProjectsUpdateProjectRequest
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the project
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="canonicalName">
        /// Canonical name of the project (unique per developer)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsUpdateProjectRequest(
            string name,
            object? metadata,
            string? canonicalName)
        {
            this.Metadata = metadata;
            this.CanonicalName = canonicalName;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateProjectRequest" /> class.
        /// </summary>
        public ProjectsUpdateProjectRequest()
        {
        }

    }
}