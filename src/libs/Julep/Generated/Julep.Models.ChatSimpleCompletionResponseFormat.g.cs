
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSimpleCompletionResponseFormat
    {
        /// <summary>
        /// The format of the response<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::Julep.ChatSimpleCompletionResponseFormatType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ChatSimpleCompletionResponseFormatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ChatSimpleCompletionResponseFormatType Type { get; set; } = global::Julep.ChatSimpleCompletionResponseFormatType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSimpleCompletionResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The format of the response<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSimpleCompletionResponseFormat(
            global::Julep.ChatSimpleCompletionResponseFormatType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSimpleCompletionResponseFormat" /> class.
        /// </summary>
        public ChatSimpleCompletionResponseFormat()
        {
        }
    }
}