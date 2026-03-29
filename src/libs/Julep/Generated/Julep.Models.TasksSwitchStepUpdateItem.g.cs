
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksSwitchStepUpdateItem
    {
        /// <summary>
        /// The cond tree
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.TasksCaseThenUpdateItem> Switch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSwitchStepUpdateItem" /> class.
        /// </summary>
        /// <param name="switch">
        /// The cond tree
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksSwitchStepUpdateItem(
            global::System.Collections.Generic.IList<global::Julep.TasksCaseThenUpdateItem> @switch)
        {
            this.Switch = @switch ?? throw new global::System.ArgumentNullException(nameof(@switch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSwitchStepUpdateItem" /> class.
        /// </summary>
        public TasksSwitchStepUpdateItem()
        {
        }
    }
}