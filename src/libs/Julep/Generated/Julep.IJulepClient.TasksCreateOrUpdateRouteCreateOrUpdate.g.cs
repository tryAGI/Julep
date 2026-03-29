#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create or update a task
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.TasksTask> TasksCreateOrUpdateRouteCreateOrUpdateAsync(
            global::System.Guid parentId,
            global::System.Guid id,

            global::Julep.TasksCreateTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a task
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="id"></param>
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
        global::System.Threading.Tasks.Task<global::Julep.TasksTask> TasksCreateOrUpdateRouteCreateOrUpdateAsync(
            global::System.Guid parentId,
            global::System.Guid id,
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStep, global::Julep.TasksSwitchStep, global::Julep.TasksForeachStep, global::Julep.TasksParallelStep, global::Julep.TasksCreateTaskRequestMainItem>> main,
            global::System.Collections.Generic.IList<global::Julep.TasksTaskTool> tools,
            bool inheritTools,
            string? canonicalName = default,
            object? inputSchema = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}