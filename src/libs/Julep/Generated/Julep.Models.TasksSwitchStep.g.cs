
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksSwitchStep
    {
        /// <summary>
        /// Default Value: switch<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksSwitchStepKindJsonConverter))]
        public global::Julep.TasksSwitchStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The cond tree
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.TasksCaseThen> Switch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSwitchStep" /> class.
        /// </summary>
        /// <param name="switch">
        /// The cond tree
        /// </param>
        /// <param name="kind">
        /// Default Value: switch<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksSwitchStep(
            global::System.Collections.Generic.IList<global::Julep.TasksCaseThen> @switch,
            global::Julep.TasksSwitchStepKind kind = default!)
        {
            this.Kind = kind;
            this.Switch = @switch ?? throw new global::System.ArgumentNullException(nameof(@switch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSwitchStep" /> class.
        /// </summary>
        public TasksSwitchStep()
        {
        }

    }
}