
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesDrag
    {
        /// <summary>
        /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
        /// Default Value: drag
        /// </summary>
        /// <default>global::Julep.ResponsesDragType.Drag</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesDragTypeJsonConverter))]
        public global::Julep.ResponsesDragType Type { get; set; } = global::Julep.ResponsesDragType.Drag;

        /// <summary>
        /// An array of coordinates representing the path of the drag action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ResponsesCoordinate> Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesDrag" /> class.
        /// </summary>
        /// <param name="path">
        /// An array of coordinates representing the path of the drag action.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
        /// Default Value: drag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesDrag(
            global::System.Collections.Generic.IList<global::Julep.ResponsesCoordinate> path,
            global::Julep.ResponsesDragType type = global::Julep.ResponsesDragType.Drag)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesDrag" /> class.
        /// </summary>
        public ResponsesDrag()
        {
        }

    }
}