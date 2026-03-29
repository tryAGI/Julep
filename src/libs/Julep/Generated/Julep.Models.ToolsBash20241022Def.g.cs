
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBash20241022Def
    {
        /// <summary>
        /// Default Value: bash_20241022
        /// </summary>
        /// <default>global::Julep.ToolsBash20241022DefType.Bash20241022</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBash20241022DefTypeJsonConverter))]
        public global::Julep.ToolsBash20241022DefType Type { get; set; } = global::Julep.ToolsBash20241022DefType.Bash20241022;

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
        /// Initializes a new instance of the <see cref="ToolsBash20241022Def" /> class.
        /// </summary>
        /// <param name="name">
        /// Default Value: bash
        /// </param>
        /// <param name="type">
        /// Default Value: bash_20241022
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBash20241022Def(
            string? name,
            global::Julep.ToolsBash20241022DefType type = global::Julep.ToolsBash20241022DefType.Bash20241022)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBash20241022Def" /> class.
        /// </summary>
        public ToolsBash20241022Def()
        {
        }
    }
}