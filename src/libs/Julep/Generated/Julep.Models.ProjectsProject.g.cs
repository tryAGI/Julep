
#nullable enable

namespace Julep
{
    /// <summary>
    /// Project model
    /// </summary>
    public sealed partial class ProjectsProject
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ProjectsProject" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the project
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="canonicalName">
        /// Canonical name of the project (unique per developer)
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsProject(
            string name,
            object? metadata,
            string? canonicalName,
            global::System.Guid id = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Id = id;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CanonicalName = canonicalName;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsProject" /> class.
        /// </summary>
        public ProjectsProject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectsProject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectsProject FromName(string name)
        {
            return new ProjectsProject
            {
                Name = name,
            };
        }

    }
}