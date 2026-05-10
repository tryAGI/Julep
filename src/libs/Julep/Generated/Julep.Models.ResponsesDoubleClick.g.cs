
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesDoubleClick
    {
        /// <summary>
        /// Specifies the event type. For a double click action, this property is always set to `double_click`.<br/>
        /// Default Value: double_click
        /// </summary>
        /// <default>global::Julep.ResponsesDoubleClickType.DoubleClick</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesDoubleClickTypeJsonConverter))]
        public global::Julep.ResponsesDoubleClickType Type { get; set; } = global::Julep.ResponsesDoubleClickType.DoubleClick;

        /// <summary>
        /// The x-coordinate where the double click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate where the double click occurred.
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
        /// Initializes a new instance of the <see cref="ResponsesDoubleClick" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-coordinate where the double click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the double click occurred.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a double click action, this property is always set to `double_click`.<br/>
        /// Default Value: double_click
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesDoubleClick(
            int x,
            int y,
            global::Julep.ResponsesDoubleClickType type = global::Julep.ResponsesDoubleClickType.DoubleClick)
        {
            this.Type = type;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesDoubleClick" /> class.
        /// </summary>
        public ResponsesDoubleClick()
        {
        }

    }
}