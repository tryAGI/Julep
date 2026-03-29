
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesWait
    {
        /// <summary>
        /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
        /// Default Value: wait
        /// </summary>
        /// <default>global::Julep.ResponsesWaitType.Wait</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesWaitTypeJsonConverter))]
        public global::Julep.ResponsesWaitType Type { get; set; } = global::Julep.ResponsesWaitType.Wait;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWait" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
        /// Default Value: wait
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWait(
            global::Julep.ResponsesWaitType type = global::Julep.ResponsesWaitType.Wait)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWait" /> class.
        /// </summary>
        public ResponsesWait()
        {
        }
    }
}