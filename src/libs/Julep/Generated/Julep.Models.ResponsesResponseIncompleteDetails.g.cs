
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesResponseIncompleteDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesResponseIncompleteDetailsReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesResponseIncompleteDetailsReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponseIncompleteDetails" /> class.
        /// </summary>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesResponseIncompleteDetails(
            global::Julep.ResponsesResponseIncompleteDetailsReason reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponseIncompleteDetails" /> class.
        /// </summary>
        public ResponsesResponseIncompleteDetails()
        {
        }

    }
}