
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesMove
    {
        /// <summary>
        /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
        /// Default Value: move
        /// </summary>
        /// <default>global::Julep.ResponsesMoveType.Move</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesMoveTypeJsonConverter))]
        public global::Julep.ResponsesMoveType Type { get; set; } = global::Julep.ResponsesMoveType.Move;

        /// <summary>
        /// The x-coordinate to move to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate to move to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesMove" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-coordinate to move to.
        /// </param>
        /// <param name="y">
        /// The y-coordinate to move to.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
        /// Default Value: move
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesMove(
            int x,
            int y,
            global::Julep.ResponsesMoveType type = global::Julep.ResponsesMoveType.Move)
        {
            this.Type = type;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesMove" /> class.
        /// </summary>
        public ResponsesMove()
        {
        }
    }
}