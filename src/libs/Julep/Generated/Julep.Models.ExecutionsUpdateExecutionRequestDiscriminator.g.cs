
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionsUpdateExecutionRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ExecutionsUpdateExecutionRequestDiscriminatorStatusJsonConverter))]
        public global::Julep.ExecutionsUpdateExecutionRequestDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsUpdateExecutionRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsUpdateExecutionRequestDiscriminator(
            global::Julep.ExecutionsUpdateExecutionRequestDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsUpdateExecutionRequestDiscriminator" /> class.
        /// </summary>
        public ExecutionsUpdateExecutionRequestDiscriminator()
        {
        }

    }
}