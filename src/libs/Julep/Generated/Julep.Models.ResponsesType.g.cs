
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesType
    {
        /// <summary>
        /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
        /// Default Value: type
        /// </summary>
        /// <default>global::Julep.ResponsesTypeType.Type</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesTypeTypeJsonConverter))]
        public global::Julep.ResponsesTypeType Type { get; set; } = global::Julep.ResponsesTypeType.Type;

        /// <summary>
        /// The text to type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesType" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to type.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
        /// Default Value: type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesType(
            string text,
            global::Julep.ResponsesTypeType type = global::Julep.ResponsesTypeType.Type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesType" /> class.
        /// </summary>
        public ResponsesType()
        {
        }
    }
}