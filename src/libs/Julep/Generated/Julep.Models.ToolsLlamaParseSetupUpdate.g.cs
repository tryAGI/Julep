
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for LlamaParse integration
    /// </summary>
    public sealed partial class ToolsLlamaParseSetupUpdate
    {
        /// <summary>
        /// The API key for LlamaParse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llamaparse_api_key")]
        public string? LlamaparseApiKey { get; set; }

        /// <summary>
        /// Optional upload parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsLlamaParseSetupUpdate" /> class.
        /// </summary>
        /// <param name="llamaparseApiKey">
        /// The API key for LlamaParse
        /// </param>
        /// <param name="params">
        /// Optional upload parameters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsLlamaParseSetupUpdate(
            string? llamaparseApiKey,
            object? @params)
        {
            this.LlamaparseApiKey = llamaparseApiKey;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsLlamaParseSetupUpdate" /> class.
        /// </summary>
        public ToolsLlamaParseSetupUpdate()
        {
        }

    }
}