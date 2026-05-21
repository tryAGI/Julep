
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksCaseThenUpdateItem
    {
        /// <summary>
        /// The condition to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::Julep.TasksCaseThenUpdateItemCase?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::Julep.TasksCaseThenUpdateItemCase?> Case { get; set; }

        /// <summary>
        /// The steps to run if the condition is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("then")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep> Then { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksCaseThenUpdateItem" /> class.
        /// </summary>
        /// <param name="case">
        /// The condition to evaluate
        /// </param>
        /// <param name="then">
        /// The steps to run if the condition is true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksCaseThenUpdateItem(
            global::Julep.AnyOf<string, global::Julep.TasksCaseThenUpdateItemCase?> @case,
            global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep> then)
        {
            this.Case = @case;
            this.Then = then;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksCaseThenUpdateItem" /> class.
        /// </summary>
        public TasksCaseThenUpdateItem()
        {
        }

    }
}