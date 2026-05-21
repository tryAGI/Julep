
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBrowserbaseContextArgumentsUpdate
    {
        /// <summary>
        /// The Project ID. Can be found in Settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseContextArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in Settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseContextArgumentsUpdate(
            string? projectId)
        {
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseContextArgumentsUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseContextArgumentsUpdate()
        {
        }

    }
}