
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesComputerTool
    {
        /// <summary>
        /// The type of the computer use tool. Always `computer_use_preview`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesComputerToolTypeJsonConverter))]
        public global::Julep.ResponsesComputerToolType Type { get; set; }

        /// <summary>
        /// The width of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float DisplayWidth { get; set; }

        /// <summary>
        /// The height of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float DisplayHeight { get; set; }

        /// <summary>
        /// The type of computer environment to control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesComputerToolEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesComputerToolEnvironment Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesComputerTool" /> class.
        /// </summary>
        /// <param name="displayWidth">
        /// The width of the computer display.
        /// </param>
        /// <param name="displayHeight">
        /// The height of the computer display.
        /// </param>
        /// <param name="environment">
        /// The type of computer environment to control.
        /// </param>
        /// <param name="type">
        /// The type of the computer use tool. Always `computer_use_preview`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesComputerTool(
            float displayWidth,
            float displayHeight,
            global::Julep.ResponsesComputerToolEnvironment environment,
            global::Julep.ResponsesComputerToolType type)
        {
            this.Type = type;
            this.DisplayWidth = displayWidth;
            this.DisplayHeight = displayHeight;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesComputerTool" /> class.
        /// </summary>
        public ResponsesComputerTool()
        {
        }

    }
}