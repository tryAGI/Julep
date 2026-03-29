
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksForeachStep
    {
        /// <summary>
        /// Default Value: foreach<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksForeachStepKindJsonConverter))]
        public global::Julep.TasksForeachStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The steps to run for each iteration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreach")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.TasksForeachDo Foreach { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksForeachStep" /> class.
        /// </summary>
        /// <param name="foreach">
        /// The steps to run for each iteration
        /// </param>
        /// <param name="kind">
        /// Default Value: foreach<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksForeachStep(
            global::Julep.TasksForeachDo @foreach,
            global::Julep.TasksForeachStepKind kind = default!)
        {
            this.Kind = kind;
            this.Foreach = @foreach ?? throw new global::System.ArgumentNullException(nameof(@foreach));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksForeachStep" /> class.
        /// </summary>
        public TasksForeachStep()
        {
        }
    }
}