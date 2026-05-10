
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments to list available tools
    /// </summary>
    public sealed partial class ToolsMcpListToolsArgumentsUpdate
    {
        /// <summary>
        /// Default Value: dummy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dummy")]
        public string? Dummy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpListToolsArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="dummy">
        /// Default Value: dummy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMcpListToolsArgumentsUpdate(
            string? dummy)
        {
            this.Dummy = dummy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpListToolsArgumentsUpdate" /> class.
        /// </summary>
        public ToolsMcpListToolsArgumentsUpdate()
        {
        }

    }
}