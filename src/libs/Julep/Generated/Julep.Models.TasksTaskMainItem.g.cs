
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksTaskMainItem
    {
        /// <summary>
        /// Default Value: map_reduce<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksTaskMainItemKindJsonConverter))]
        public global::Julep.TasksTaskMainItemKind Kind { get; set; } = default!;

        /// <summary>
        /// The variable to iterate over
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("over")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Over { get; set; }

        /// <summary>
        /// The steps to run for each iteration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep> Map { get; set; }

        /// <summary>
        /// The expression to reduce the results.<br/>
        /// If not provided, the results are collected and returned as a list.<br/>
        /// A special parameter named `results` is the accumulator and `_` is the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reduce")]
        public string? Reduce { get; set; }

        /// <summary>
        /// The initial value of the reduce expression<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial")]
        public object? Initial { get; set; }

        /// <summary>
        /// Whether to run the reduce expression in parallel and how many items to run in each batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallelism")]
        public int? Parallelism { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksTaskMainItem" /> class.
        /// </summary>
        /// <param name="over">
        /// The variable to iterate over
        /// </param>
        /// <param name="map">
        /// The steps to run for each iteration
        /// </param>
        /// <param name="reduce">
        /// The expression to reduce the results.<br/>
        /// If not provided, the results are collected and returned as a list.<br/>
        /// A special parameter named `results` is the accumulator and `_` is the current value.
        /// </param>
        /// <param name="initial">
        /// The initial value of the reduce expression<br/>
        /// Default Value: []
        /// </param>
        /// <param name="parallelism">
        /// Whether to run the reduce expression in parallel and how many items to run in each batch
        /// </param>
        /// <param name="kind">
        /// Default Value: map_reduce<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksTaskMainItem(
            string over,
            global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep> map,
            string? reduce,
            object? initial,
            int? parallelism,
            global::Julep.TasksTaskMainItemKind kind = default!)
        {
            this.Kind = kind;
            this.Over = over ?? throw new global::System.ArgumentNullException(nameof(over));
            this.Map = map;
            this.Reduce = reduce;
            this.Initial = initial;
            this.Parallelism = parallelism;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksTaskMainItem" /> class.
        /// </summary>
        public TasksTaskMainItem()
        {
        }

    }
}