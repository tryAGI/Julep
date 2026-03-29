
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksWaitForInputStep
    {
        /// <summary>
        /// Default Value: wait_for_input<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksWaitForInputStepKindJsonConverter))]
        public global::Julep.TasksWaitForInputStepKind Kind { get; set; } = default!;

        /// <summary>
        /// Any additional info or data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.TasksWaitForInputInfo WaitForInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksWaitForInputStep" /> class.
        /// </summary>
        /// <param name="waitForInput">
        /// Any additional info or data
        /// </param>
        /// <param name="kind">
        /// Default Value: wait_for_input<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksWaitForInputStep(
            global::Julep.TasksWaitForInputInfo waitForInput,
            global::Julep.TasksWaitForInputStepKind kind = default!)
        {
            this.Kind = kind;
            this.WaitForInput = waitForInput ?? throw new global::System.ArgumentNullException(nameof(waitForInput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksWaitForInputStep" /> class.
        /// </summary>
        public TasksWaitForInputStep()
        {
        }
    }
}