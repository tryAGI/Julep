
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsChosenBash20241022
    {
        /// <summary>
        /// The bash command to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

        /// <summary>
        /// Whether to restart the tool<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restart")]
        public bool? Restart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsChosenBash20241022" /> class.
        /// </summary>
        /// <param name="command">
        /// The bash command to run
        /// </param>
        /// <param name="restart">
        /// Whether to restart the tool<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsChosenBash20241022(
            string? command,
            bool? restart)
        {
            this.Command = command;
            this.Restart = restart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsChosenBash20241022" /> class.
        /// </summary>
        public ToolsChosenBash20241022()
        {
        }
    }
}