
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksReturnStep
    {
        /// <summary>
        /// Default Value: return<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksReturnStepKindJsonConverter))]
        public global::Julep.TasksReturnStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The value to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Return { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksReturnStep" /> class.
        /// </summary>
        /// <param name="return">
        /// The value to return
        /// </param>
        /// <param name="kind">
        /// Default Value: return<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksReturnStep(
            object @return,
            global::Julep.TasksReturnStepKind kind = default!)
        {
            this.Kind = kind;
            this.Return = @return ?? throw new global::System.ArgumentNullException(nameof(@return));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksReturnStep" /> class.
        /// </summary>
        public TasksReturnStep()
        {
        }
    }
}