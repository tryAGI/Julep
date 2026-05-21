
#nullable enable

namespace Julep
{
    /// <summary>
    /// Anthropic new tools
    /// </summary>
    public sealed partial class ToolsComputer20241022Def
    {
        /// <summary>
        /// Default Value: computer_20241022
        /// </summary>
        /// <default>global::Julep.ToolsComputer20241022DefType.Computer20241022</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsComputer20241022DefTypeJsonConverter))]
        public global::Julep.ToolsComputer20241022DefType Type { get; set; } = global::Julep.ToolsComputer20241022DefType.Computer20241022;

        /// <summary>
        /// Default Value: computer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The display width in pixels<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayWidthPx { get; set; }

        /// <summary>
        /// The display height in pixels<br/>
        /// Default Value: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayHeightPx { get; set; }

        /// <summary>
        /// The display number to use<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_number")]
        public int? DisplayNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsComputer20241022Def" /> class.
        /// </summary>
        /// <param name="displayWidthPx">
        /// The display width in pixels<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="displayHeightPx">
        /// The display height in pixels<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="name">
        /// Default Value: computer
        /// </param>
        /// <param name="displayNumber">
        /// The display number to use<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="type">
        /// Default Value: computer_20241022
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsComputer20241022Def(
            int displayWidthPx,
            int displayHeightPx,
            string? name,
            int? displayNumber,
            global::Julep.ToolsComputer20241022DefType type = global::Julep.ToolsComputer20241022DefType.Computer20241022)
        {
            this.Type = type;
            this.Name = name;
            this.DisplayWidthPx = displayWidthPx;
            this.DisplayHeightPx = displayHeightPx;
            this.DisplayNumber = displayNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsComputer20241022Def" /> class.
        /// </summary>
        public ToolsComputer20241022Def()
        {
        }

    }
}