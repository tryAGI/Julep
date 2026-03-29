
#nullable enable

namespace Julep
{
    /// <summary>
    /// Function definition
    /// </summary>
    public sealed partial class ToolsFunctionDef
    {
        /// <summary>
        /// DO NOT USE: This will be overriden by the tool name. Here only for compatibility reasons.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public object? Name { get; set; }

        /// <summary>
        /// DO NOT USE: This will be overriden by the tool description. Here only for compatibility reasons.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public object? Description { get; set; }

        /// <summary>
        /// The parameters the function accepts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFunctionDef" /> class.
        /// </summary>
        /// <param name="name">
        /// DO NOT USE: This will be overriden by the tool name. Here only for compatibility reasons.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// DO NOT USE: This will be overriden by the tool description. Here only for compatibility reasons.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="parameters">
        /// The parameters the function accepts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsFunctionDef(
            object? name,
            object? description,
            object? parameters)
        {
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFunctionDef" /> class.
        /// </summary>
        public ToolsFunctionDef()
        {
        }
    }
}