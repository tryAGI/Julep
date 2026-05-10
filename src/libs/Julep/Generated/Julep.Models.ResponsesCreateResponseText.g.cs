
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesCreateResponseText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ResponsesResponseFormatText, global::Julep.ResponsesTextResponseFormatJsonSchema, global::Julep.ResponsesResponseFormatJsonObject>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.ResponsesResponseFormatText, global::Julep.ResponsesTextResponseFormatJsonSchema, global::Julep.ResponsesResponseFormatJsonObject> Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCreateResponseText" /> class.
        /// </summary>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesCreateResponseText(
            global::Julep.AnyOf<global::Julep.ResponsesResponseFormatText, global::Julep.ResponsesTextResponseFormatJsonSchema, global::Julep.ResponsesResponseFormatJsonObject> format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCreateResponseText" /> class.
        /// </summary>
        public ResponsesCreateResponseText()
        {
        }

    }
}