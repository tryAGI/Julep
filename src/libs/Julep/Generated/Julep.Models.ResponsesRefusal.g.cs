
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesRefusal
    {
        /// <summary>
        /// The type of the refusal. Always `refusal`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesRefusalTypeJsonConverter))]
        public global::Julep.ResponsesRefusalType Type { get; set; }

        /// <summary>
        /// The refusal explanation from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRefusal" /> class.
        /// </summary>
        /// <param name="refusal">
        /// The refusal explanation from the model.
        /// </param>
        /// <param name="type">
        /// The type of the refusal. Always `refusal`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRefusal(
            string refusal,
            global::Julep.ResponsesRefusalType type)
        {
            this.Type = type;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRefusal" /> class.
        /// </summary>
        public ResponsesRefusal()
        {
        }

    }
}