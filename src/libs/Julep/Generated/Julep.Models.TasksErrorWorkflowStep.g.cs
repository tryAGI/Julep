
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksErrorWorkflowStep
    {
        /// <summary>
        /// Default Value: error<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksErrorWorkflowStepKindJsonConverter))]
        public global::Julep.TasksErrorWorkflowStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksErrorWorkflowStep" /> class.
        /// </summary>
        /// <param name="error">
        /// The error message
        /// </param>
        /// <param name="kind">
        /// Default Value: error<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksErrorWorkflowStep(
            string error,
            global::Julep.TasksErrorWorkflowStepKind kind = default!)
        {
            this.Kind = kind;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksErrorWorkflowStep" /> class.
        /// </summary>
        public TasksErrorWorkflowStep()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksErrorWorkflowStep"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksErrorWorkflowStep FromError(string error)
        {
            return new TasksErrorWorkflowStep
            {
                Error = error,
            };
        }

    }
}