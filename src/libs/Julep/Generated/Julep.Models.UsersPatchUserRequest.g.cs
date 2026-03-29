
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for patching a user
    /// </summary>
    public sealed partial class UsersPatchUserRequest
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
        public string? Name { get; set; }

        /// <summary>
        /// About the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about")]
        public string? About { get; set; }

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
        /// Initializes a new instance of the <see cref="UsersPatchUserRequest" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="name">
        /// Name of the user
        /// </param>
        /// <param name="about">
        /// About the user
        /// </param>
        /// <param name="project">
        /// Project canonical name of the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersPatchUserRequest(
            object? metadata,
            string? name,
            string? about,
            string? project)
        {
            this.Metadata = metadata;
            this.Name = name;
            this.About = about;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersPatchUserRequest" /> class.
        /// </summary>
        public UsersPatchUserRequest()
        {
        }
    }
}