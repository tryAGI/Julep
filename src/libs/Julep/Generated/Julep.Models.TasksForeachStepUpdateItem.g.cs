
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksForeachStepUpdateItem
    {
        /// <summary>
        /// The steps to run for each iteration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreach")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.TasksForeachDoUpdateItem Foreach { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksForeachStepUpdateItem" /> class.
        /// </summary>
        /// <param name="foreach">
        /// The steps to run for each iteration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksForeachStepUpdateItem(
            global::Julep.TasksForeachDoUpdateItem @foreach)
        {
            this.Foreach = @foreach ?? throw new global::System.ArgumentNullException(nameof(@foreach));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksForeachStepUpdateItem" /> class.
        /// </summary>
        public TasksForeachStepUpdateItem()
        {
        }

    }
}