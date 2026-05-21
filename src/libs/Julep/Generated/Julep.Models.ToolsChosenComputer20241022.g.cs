
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsChosenComputer20241022
    {
        /// <summary>
        /// The action to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsComputer20241022ActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsComputer20241022Action Action { get; set; }

        /// <summary>
        /// The text to type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The (x, y) pixel coordinate to move the cursor to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinate")]
        public global::System.Collections.Generic.IList<int>? Coordinate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsChosenComputer20241022" /> class.
        /// </summary>
        /// <param name="action">
        /// The action to perform
        /// </param>
        /// <param name="text">
        /// The text to type
        /// </param>
        /// <param name="coordinate">
        /// The (x, y) pixel coordinate to move the cursor to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsChosenComputer20241022(
            global::Julep.ToolsComputer20241022Action action,
            string? text,
            global::System.Collections.Generic.IList<int>? coordinate)
        {
            this.Action = action;
            this.Text = text;
            this.Coordinate = coordinate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsChosenComputer20241022" /> class.
        /// </summary>
        public ToolsChosenComputer20241022()
        {
        }

    }
}