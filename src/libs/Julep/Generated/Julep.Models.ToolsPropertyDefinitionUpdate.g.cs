
#nullable enable

namespace Julep
{
    /// <summary>
    /// Property definition for parameter schema
    /// </summary>
    public sealed partial class ToolsPropertyDefinitionUpdate
    {
        /// <summary>
        /// Type of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Description of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Enum values if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Items definition for array types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Julep.ToolsPropertyDefinitionUpdate? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPropertyDefinitionUpdate" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the property
        /// </param>
        /// <param name="description">
        /// Description of the property
        /// </param>
        /// <param name="enum">
        /// Enum values if applicable
        /// </param>
        /// <param name="items">
        /// Items definition for array types
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsPropertyDefinitionUpdate(
            string? type,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            global::Julep.ToolsPropertyDefinitionUpdate? items)
        {
            this.Type = type;
            this.Description = description;
            this.Enum = @enum;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPropertyDefinitionUpdate" /> class.
        /// </summary>
        public ToolsPropertyDefinitionUpdate()
        {
        }
    }
}