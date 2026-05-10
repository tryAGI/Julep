
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for creating a user (and associated documents)
    /// </summary>
    public sealed partial class UsersCreateUserRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// About the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string About { get; set; }

        /// <summary>
        /// Project canonical name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreateUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the user
        /// </param>
        /// <param name="about">
        /// About the user
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="project">
        /// Project canonical name of the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersCreateUserRequest(
            string name,
            string about,
            object? metadata,
            string? project)
        {
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.About = about ?? throw new global::System.ArgumentNullException(nameof(about));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreateUserRequest" /> class.
        /// </summary>
        public UsersCreateUserRequest()
        {
        }

    }
}