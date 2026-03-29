
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksSleepStep
    {
        /// <summary>
        /// Default Value: sleep<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksSleepStepKindJsonConverter))]
        public global::Julep.TasksSleepStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The duration to sleep for (max 31 days)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.TasksSleepFor Sleep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSleepStep" /> class.
        /// </summary>
        /// <param name="sleep">
        /// The duration to sleep for (max 31 days)
        /// </param>
        /// <param name="kind">
        /// Default Value: sleep<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksSleepStep(
            global::Julep.TasksSleepFor sleep,
            global::Julep.TasksSleepStepKind kind = default!)
        {
            this.Kind = kind;
            this.Sleep = sleep ?? throw new global::System.ArgumentNullException(nameof(sleep));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSleepStep" /> class.
        /// </summary>
        public TasksSleepStep()
        {
        }
    }
}