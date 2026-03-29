
#nullable enable

namespace Julep
{
    /// <summary>
    /// JSON Schema for API call parameters
    /// </summary>
    public sealed partial class ToolsParameterSchema
    {
        /// <summary>
        /// Schema type (usually 'object')<br/>
        /// Default Value: object
        /// </summary>
        /// <default>"object"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "object";

        /// <summary>
        /// Properties definition for parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsPropertyDefinition> Properties { get; set; }

        /// <summary>
        /// List of required property names<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Whether to allow additional properties
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsParameterSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Schema type (usually 'object')<br/>
        /// Default Value: object
        /// </param>
        /// <param name="properties">
        /// Properties definition for parameters
        /// </param>
        /// <param name="required">
        /// List of required property names<br/>
        /// Default Value: []
        /// </param>
        /// <param name="additionalProperties">
        /// Whether to allow additional properties
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsParameterSchema(
            string type,
            global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsPropertyDefinition> properties,
            global::System.Collections.Generic.IList<string>? required,
            bool? additionalProperties)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsParameterSchema" /> class.
        /// </summary>
        public ToolsParameterSchema()
        {
        }
    }
}