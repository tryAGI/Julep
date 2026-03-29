
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksIfElseWorkflowStepUpdateItem
    {
        /// <summary>
        /// The condition to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("if")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string If { get; set; }

        /// <summary>
        /// The steps to run if the condition is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("then")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksIfElseWorkflowStepUpdateItemThen>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksIfElseWorkflowStepUpdateItemThen> Then { get; set; }

        /// <summary>
        /// The steps to run if the condition is false<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("else")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksIfElseWorkflowStepUpdateItemElse>))]
        public global::Julep.AnyOf<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksIfElseWorkflowStepUpdateItemElse>? Else { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksIfElseWorkflowStepUpdateItem" /> class.
        /// </summary>
        /// <param name="if">
        /// The condition to evaluate
        /// </param>
        /// <param name="then">
        /// The steps to run if the condition is true
        /// </param>
        /// <param name="else">
        /// The steps to run if the condition is false<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksIfElseWorkflowStepUpdateItem(
            string @if,
            global::Julep.AnyOf<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksIfElseWorkflowStepUpdateItemThen> then,
            global::Julep.AnyOf<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksIfElseWorkflowStepUpdateItem, global::Julep.TasksSwitchStepUpdateItem, global::Julep.TasksForeachStepUpdateItem, global::Julep.TasksParallelStepUpdateItem, global::Julep.TasksIfElseWorkflowStepUpdateItemElse>? @else)
        {
            this.If = @if ?? throw new global::System.ArgumentNullException(nameof(@if));
            this.Then = then;
            this.Else = @else;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksIfElseWorkflowStepUpdateItem" /> class.
        /// </summary>
        public TasksIfElseWorkflowStepUpdateItem()
        {
        }
    }
}