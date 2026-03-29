
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksSetStep
    {
        /// <summary>
        /// Default Value: set<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksSetStepKindJsonConverter))]
        public global::Julep.TasksSetStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The value to set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Set { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSetStep" /> class.
        /// </summary>
        /// <param name="set">
        /// The value to set
        /// </param>
        /// <param name="kind">
        /// Default Value: set<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksSetStep(
            object set,
            global::Julep.TasksSetStepKind kind = default!)
        {
            this.Kind = kind;
            this.Set = set ?? throw new global::System.ArgumentNullException(nameof(set));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSetStep" /> class.
        /// </summary>
        public TasksSetStep()
        {
        }
    }
}