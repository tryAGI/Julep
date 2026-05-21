
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBrowserbaseCompleteSessionArgumentsUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: REQUEST_RELEASE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseCompleteSessionArgumentsUpdateStatusJsonConverter))]
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCompleteSessionArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// Default Value: REQUEST_RELEASE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseCompleteSessionArgumentsUpdate(
            string? id,
            global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus? status)
        {
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCompleteSessionArgumentsUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseCompleteSessionArgumentsUpdate()
        {
        }

    }
}