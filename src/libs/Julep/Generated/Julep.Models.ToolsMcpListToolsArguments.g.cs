
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments to list available tools
    /// </summary>
    public sealed partial class ToolsMcpListToolsArguments
    {
        /// <summary>
        /// Default Value: dummy
        /// </summary>
        /// <default>"dummy"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("dummy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dummy { get; set; } = "dummy";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpListToolsArguments" /> class.
        /// </summary>
        /// <param name="dummy">
        /// Default Value: dummy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMcpListToolsArguments(
            string dummy)
        {
            this.Dummy = dummy ?? throw new global::System.ArgumentNullException(nameof(dummy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpListToolsArguments" /> class.
        /// </summary>
        public ToolsMcpListToolsArguments()
        {
        }
    }
}