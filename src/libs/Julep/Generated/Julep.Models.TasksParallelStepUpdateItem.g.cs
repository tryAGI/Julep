
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksParallelStepUpdateItem
    {
        /// <summary>
        /// The steps to run in parallel. Max concurrency will depend on the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>> Parallel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksParallelStepUpdateItem" /> class.
        /// </summary>
        /// <param name="parallel">
        /// The steps to run in parallel. Max concurrency will depend on the platform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksParallelStepUpdateItem(
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>> parallel)
        {
            this.Parallel = parallel ?? throw new global::System.ArgumentNullException(nameof(parallel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksParallelStepUpdateItem" /> class.
        /// </summary>
        public TasksParallelStepUpdateItem()
        {
        }

    }
}