
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSchemaCompletionResponseFormat
    {
        /// <summary>
        /// The format of the response<br/>
        /// Default Value: json_schema
        /// </summary>
        /// <default>global::Julep.ChatSchemaCompletionResponseFormatType.JsonSchema</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ChatSchemaCompletionResponseFormatTypeJsonConverter))]
        public global::Julep.ChatSchemaCompletionResponseFormatType Type { get; set; } = global::Julep.ChatSchemaCompletionResponseFormatType.JsonSchema;

        /// <summary>
        /// The schema of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSchemaCompletionResponseFormat" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// The schema of the response
        /// </param>
        /// <param name="type">
        /// The format of the response<br/>
        /// Default Value: json_schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSchemaCompletionResponseFormat(
            object jsonSchema,
            global::Julep.ChatSchemaCompletionResponseFormatType type = global::Julep.ChatSchemaCompletionResponseFormatType.JsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSchemaCompletionResponseFormat" /> class.
        /// </summary>
        public ChatSchemaCompletionResponseFormat()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatSchemaCompletionResponseFormat"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatSchemaCompletionResponseFormat FromJsonSchema(object jsonSchema)
        {
            return new ChatSchemaCompletionResponseFormat
            {
                JsonSchema = jsonSchema,
            };
        }

    }
}