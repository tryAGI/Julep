
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBrowserbaseExtensionArgumentsUpdate
    {
        /// <summary>
        /// The GitHub repository name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryName")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// Ref to install from a branch or tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseExtensionArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="repositoryName">
        /// The GitHub repository name.
        /// </param>
        /// <param name="ref">
        /// Ref to install from a branch or tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseExtensionArgumentsUpdate(
            string? repositoryName,
            string? @ref)
        {
            this.RepositoryName = repositoryName;
            this.Ref = @ref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseExtensionArgumentsUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseExtensionArgumentsUpdate()
        {
        }

    }
}