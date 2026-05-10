
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPatchTaskRequestMainItemVariant1
    {
        /// <summary>
        /// The label of this step for referencing it from other steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Discriminator property for BaseWorkflowStep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPatchTaskRequestMainItemVariant1" /> class.
        /// </summary>
        /// <param name="label">
        /// The label of this step for referencing it from other steps
        /// </param>
        /// <param name="kind">
        /// Discriminator property for BaseWorkflowStep.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPatchTaskRequestMainItemVariant1(
            string? label,
            string? kind)
        {
            this.Label = label;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPatchTaskRequestMainItemVariant1" /> class.
        /// </summary>
        public TasksPatchTaskRequestMainItemVariant1()
        {
        }

    }
}