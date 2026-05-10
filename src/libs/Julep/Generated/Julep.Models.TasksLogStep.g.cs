
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksLogStep
    {
        /// <summary>
        /// Default Value: log<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksLogStepKindJsonConverter))]
        public global::Julep.TasksLogStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The value to log
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Log { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksLogStep" /> class.
        /// </summary>
        /// <param name="log">
        /// The value to log
        /// </param>
        /// <param name="kind">
        /// Default Value: log<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksLogStep(
            string log,
            global::Julep.TasksLogStepKind kind = default!)
        {
            this.Kind = kind;
            this.Log = log ?? throw new global::System.ArgumentNullException(nameof(log));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksLogStep" /> class.
        /// </summary>
        public TasksLogStep()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksLogStep"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksLogStep FromLog(string log)
        {
            return new TasksLogStep
            {
                Log = log,
            };
        }

    }
}