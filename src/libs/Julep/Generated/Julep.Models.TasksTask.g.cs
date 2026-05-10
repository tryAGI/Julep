
#nullable enable

namespace Julep
{
    /// <summary>
    /// Object describing a Task
    /// </summary>
    public sealed partial class TasksTask
    {
        /// <summary>
        /// The name of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The canonical name of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// The description of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The entrypoint of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStep, global::Julep.TasksSwitchStep, global::Julep.TasksForeachStep, global::Julep.TasksParallelStep, global::Julep.TasksTaskMainItem>> Main { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.TasksTaskTool> Tools { get; set; }

        /// <summary>
        /// Whether to inherit tools from the parent agent or not. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InheritTools { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="TasksTask" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the task.
        /// </param>
        /// <param name="description">
        /// The description of the task.
        /// </param>
        /// <param name="main">
        /// The entrypoint of the task.
        /// </param>
        /// <param name="tools">
        /// Tools defined specifically for this task not included in the Agent itself.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="inheritTools">
        /// Whether to inherit tools from the parent agent or not. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="canonicalName">
        /// The canonical name of the task.
        /// </param>
        /// <param name="inputSchema">
        /// The schema for the input to the task. `null` means all inputs are valid.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksTask(
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStep, global::Julep.TasksSwitchStep, global::Julep.TasksForeachStep, global::Julep.TasksParallelStep, global::Julep.TasksTaskMainItem>> main,
            global::System.Collections.Generic.IList<global::Julep.TasksTaskTool> tools,
            bool inheritTools,
            string? canonicalName,
            object? inputSchema,
            object? metadata,
            global::System.Guid id = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CanonicalName = canonicalName;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Main = main ?? throw new global::System.ArgumentNullException(nameof(main));
            this.InputSchema = inputSchema;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.InheritTools = inheritTools;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksTask" /> class.
        /// </summary>
        public TasksTask()
        {
        }

    }
}