
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesFunctionToolCallOutputResource
    {
        /// <summary>
        /// The unique ID of the function call tool output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFunctionToolCallOutputResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the function call tool output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesFunctionToolCallOutputResource(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFunctionToolCallOutputResource" /> class.
        /// </summary>
        public ResponsesFunctionToolCallOutputResource()
        {
        }

    }
}