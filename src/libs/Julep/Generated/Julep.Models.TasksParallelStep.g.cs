
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksParallelStep
    {
        /// <summary>
        /// Default Value: parallel<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksParallelStepKindJsonConverter))]
        public global::Julep.TasksParallelStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The steps to run in parallel. Max concurrency will depend on the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>> Parallel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksParallelStep" /> class.
        /// </summary>
        /// <param name="parallel">
        /// The steps to run in parallel. Max concurrency will depend on the platform.
        /// </param>
        /// <param name="kind">
        /// Default Value: parallel<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksParallelStep(
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>> parallel,
            global::Julep.TasksParallelStepKind kind = default!)
        {
            this.Kind = kind;
            this.Parallel = parallel ?? throw new global::System.ArgumentNullException(nameof(parallel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksParallelStep" /> class.
        /// </summary>
        public TasksParallelStep()
        {
        }

    }
}