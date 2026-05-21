
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksEvaluateStep
    {
        /// <summary>
        /// Default Value: evaluate<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksEvaluateStepKindJsonConverter))]
        public global::Julep.TasksEvaluateStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The expression to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Evaluate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksEvaluateStep" /> class.
        /// </summary>
        /// <param name="evaluate">
        /// The expression to evaluate
        /// </param>
        /// <param name="kind">
        /// Default Value: evaluate<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksEvaluateStep(
            object evaluate,
            global::Julep.TasksEvaluateStepKind kind = default!)
        {
            this.Kind = kind;
            this.Evaluate = evaluate ?? throw new global::System.ArgumentNullException(nameof(evaluate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksEvaluateStep" /> class.
        /// </summary>
        public TasksEvaluateStep()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksEvaluateStep"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksEvaluateStep FromEvaluate(object evaluate)
        {
            return new TasksEvaluateStep
            {
                Evaluate = evaluate,
            };
        }

    }
}