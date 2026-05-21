
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for patching a task
    /// </summary>
    public sealed partial class TasksPatchTaskRequest
    {
        /// <summary>
        /// The name of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The canonical name of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// The description of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The entrypoint of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main")]
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksPatchTaskRequestMainItem>>? Main { get; set; }

        /// <summary>
        /// The schema for the input to the task. `null` means all inputs are valid.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Tools defined specifically for this task not included in the Agent itself.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Julep.TasksTaskTool>? Tools { get; set; }

        /// <summary>
        /// Whether to inherit tools from the parent agent or not. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit_tools")]
        public bool? InheritTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPatchTaskRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPatchTaskRequest(
            string? name,
            string? canonicalName,
            string? description,
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksPatchTaskRequestMainItem>>? main,
            object? inputSchema,
            global::System.Collections.Generic.IList<global::Julep.TasksTaskTool>? tools,
            bool? inheritTools,
            object? metadata)
        {
            this.Name = name;
            this.CanonicalName = canonicalName;
            this.Description = description;
            this.Main = main;
            this.InputSchema = inputSchema;
            this.Tools = tools;
            this.InheritTools = inheritTools;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPatchTaskRequest" /> class.
        /// </summary>
        public TasksPatchTaskRequest()
        {
        }

    }
}