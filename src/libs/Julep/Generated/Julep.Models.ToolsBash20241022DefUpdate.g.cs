
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBash20241022DefUpdate
    {
        /// <summary>
        /// Default Value: bash_20241022
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBash20241022DefUpdateTypeJsonConverter))]
        public global::Julep.ToolsBash20241022DefUpdateType? Type { get; set; }

        /// <summary>
        /// Default Value: bash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBash20241022DefUpdate" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: bash_20241022
        /// </param>
        /// <param name="name">
        /// Default Value: bash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBash20241022DefUpdate(
            global::Julep.ToolsBash20241022DefUpdateType? type,
            string? name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBash20241022DefUpdate" /> class.
        /// </summary>
        public ToolsBash20241022DefUpdate()
        {
        }
    }
}