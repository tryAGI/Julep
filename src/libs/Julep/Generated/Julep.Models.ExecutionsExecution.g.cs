
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionsExecution
    {
        /// <summary>
        /// The ID of the task that the execution is running<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public global::System.Guid TaskId { get; set; } = default!;

        /// <summary>
        /// The status of the execution<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ExecutionsExecutionStatusJsonConverter))]
        public global::Julep.ExecutionsExecutionStatus Status { get; set; } = default!;

        /// <summary>
        /// The input to the execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The output of the execution if it succeeded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// The error of the execution if it failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The number of transitions in this execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_count")]
        public byte? TransitionCount { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsExecution" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to the execution
        /// </param>
        /// <param name="output">
        /// The output of the execution if it succeeded
        /// </param>
        /// <param name="error">
        /// The error of the execution if it failed
        /// </param>
        /// <param name="transitionCount">
        /// The number of transitions in this execution
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="taskId">
        /// The ID of the task that the execution is running<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// The status of the execution<br/>
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
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsExecution(
            object input,
            object? output,
            string? error,
            byte? transitionCount,
            object? metadata,
            global::System.Guid taskId = default!,
            global::Julep.ExecutionsExecutionStatus status = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!,
            global::System.Guid id = default!)
        {
            this.TaskId = taskId;
            this.Status = status;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output;
            this.Error = error;
            this.TransitionCount = transitionCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsExecution" /> class.
        /// </summary>
        public ExecutionsExecution()
        {
        }
    }
}