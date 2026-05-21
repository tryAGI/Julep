
#nullable enable

namespace Julep
{
    /// <summary>
    /// JSON object response format. An older method of generating JSON responses.<br/>
    /// Using `json_schema` is recommended for models that support it. Note that the<br/>
    /// model will not generate JSON without a system or user message instructing it<br/>
    /// to do so.
    /// </summary>
    public sealed partial class ResponsesResponseFormatJsonObject
    {
        /// <summary>
        /// The type of response format being defined. Always `json_object`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesResponseFormatJsonObjectTypeJsonConverter))]
        public global::Julep.ResponsesResponseFormatJsonObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponseFormatJsonObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined. Always `json_object`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesResponseFormatJsonObject(
            global::Julep.ResponsesResponseFormatJsonObjectType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponseFormatJsonObject" /> class.
        /// </summary>
        public ResponsesResponseFormatJsonObject()
        {
        }

    }
}