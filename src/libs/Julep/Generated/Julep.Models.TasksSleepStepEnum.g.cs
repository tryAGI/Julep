
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksSleepStepEnum
    {
        /// <summary>
        /// The kind of step<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksSleepStepEnumKindJsonConverter))]
        public global::Julep.TasksSleepStepEnumKind Kind { get; set; } = default!;

        /// <summary>
        /// The label of this step for referencing it from other steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSleepStepEnum" /> class.
        /// </summary>
        /// <param name="label">
        /// The label of this step for referencing it from other steps
        /// </param>
        /// <param name="kind">
        /// The kind of step<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksSleepStepEnum(
            string? label,
            global::Julep.TasksSleepStepEnumKind kind = default!)
        {
            this.Kind = kind;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSleepStepEnum" /> class.
        /// </summary>
        public TasksSleepStepEnum()
        {
        }

    }
}