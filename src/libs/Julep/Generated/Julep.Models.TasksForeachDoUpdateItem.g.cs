
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksForeachDoUpdateItem
    {
        /// <summary>
        /// The variable to iterate over.<br/>
        /// VALIDATION: Should NOT return more than 1000 elements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string In { get; set; }

        /// <summary>
        /// The steps to run for each iteration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep> Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksForeachDoUpdateItem" /> class.
        /// </summary>
        /// <param name="in">
        /// The variable to iterate over.<br/>
        /// VALIDATION: Should NOT return more than 1000 elements.
        /// </param>
        /// <param name="do">
        /// The steps to run for each iteration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksForeachDoUpdateItem(
            string @in,
            global::Julep.AnyOf<global::Julep.TasksWaitForInputStep, global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStepUpdateItem, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep> @do)
        {
            this.In = @in ?? throw new global::System.ArgumentNullException(nameof(@in));
            this.Do = @do;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksForeachDoUpdateItem" /> class.
        /// </summary>
        public TasksForeachDoUpdateItem()
        {
        }
    }
}