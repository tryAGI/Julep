
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksYieldStep
    {
        /// <summary>
        /// Default Value: yield<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksYieldStepKindJsonConverter))]
        public global::Julep.TasksYieldStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The subworkflow to run.<br/>
        /// VALIDATION: Should resolve to a defined subworkflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Workflow { get; set; }

        /// <summary>
        /// The input parameters for the subworkflow (defaults to last step output)<br/>
        /// Default Value: _
        /// </summary>
        /// <default>"_"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<object, global::Julep.TasksYieldStepArgumentsEnum3?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<object, global::Julep.TasksYieldStepArgumentsEnum3?> Arguments { get; set; } = "_";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksYieldStep" /> class.
        /// </summary>
        /// <param name="workflow">
        /// The subworkflow to run.<br/>
        /// VALIDATION: Should resolve to a defined subworkflow.
        /// </param>
        /// <param name="arguments">
        /// The input parameters for the subworkflow (defaults to last step output)<br/>
        /// Default Value: _
        /// </param>
        /// <param name="kind">
        /// Default Value: yield<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksYieldStep(
            string workflow,
            global::Julep.AnyOf<object, global::Julep.TasksYieldStepArgumentsEnum3?> arguments,
            global::Julep.TasksYieldStepKind kind = default!)
        {
            this.Kind = kind;
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksYieldStep" /> class.
        /// </summary>
        public TasksYieldStep()
        {
        }
    }
}