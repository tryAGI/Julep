#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Update an existing task (merges with existing values)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.TasksTask> TasksRoutePatchAsync(
            global::System.Guid id,
            global::System.Guid childId,

            global::Julep.TasksPatchTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing task (merges with existing values)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="name">
        /// The name of the task.
        /// </param>
        /// <param name="canonicalName">
        /// The canonical name of the task.
        /// </param>
        /// <param name="description">
        /// The description of the task.
        /// </param>
        /// <param name="main">
        /// The entrypoint of the task.
        /// </param>
        /// <param name="inputSchema">
        /// The schema for the input to the task. `null` means all inputs are valid.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Tools defined specifically for this task not included in the Agent itself.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="inheritTools">
        /// Whether to inherit tools from the parent agent or not. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.TasksTask> TasksRoutePatchAsync(
            global::System.Guid id,
            global::System.Guid childId,
            string? name = default,
            string? canonicalName = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksPatchTaskRequestMainItem>>? main = default,
            object? inputSchema = default,
            global::System.Collections.Generic.IList<global::Julep.TasksTaskTool>? tools = default,
            bool? inheritTools = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}