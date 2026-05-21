
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksToolCallStep
    {
        /// <summary>
        /// Default Value: tool_call<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksToolCallStepKindJsonConverter))]
        public global::Julep.TasksToolCallStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The tool to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// The input parameters for the tool (defaults to last step output)<br/>
        /// Default Value: _
        /// </summary>
        /// <default>"_"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<object, global::Julep.TasksToolCallStepArgumentsEnum3?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<object, global::Julep.TasksToolCallStepArgumentsEnum3?> Arguments { get; set; } = "_";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksToolCallStep" /> class.
        /// </summary>
        /// <param name="tool">
        /// The tool to run
        /// </param>
        /// <param name="arguments">
        /// The input parameters for the tool (defaults to last step output)<br/>
        /// Default Value: _
        /// </param>
        /// <param name="kind">
        /// Default Value: tool_call<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksToolCallStep(
            string tool,
            global::Julep.AnyOf<object, global::Julep.TasksToolCallStepArgumentsEnum3?> arguments,
            global::Julep.TasksToolCallStepKind kind = default!)
        {
            this.Kind = kind;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksToolCallStep" /> class.
        /// </summary>
        public TasksToolCallStep()
        {
        }

    }
}