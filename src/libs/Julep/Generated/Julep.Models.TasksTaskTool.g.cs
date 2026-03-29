
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksTaskTool
    {
        /// <summary>
        /// Read-only: Whether the tool was inherited or not. Only applies within tasks.<br/>
        /// Default Value: false<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited")]
        public bool? Inherited { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksTaskTool" /> class.
        /// </summary>
        /// <param name="inherited">
        /// Read-only: Whether the tool was inherited or not. Only applies within tasks.<br/>
        /// Default Value: false<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksTaskTool(
            bool? inherited)
        {
            this.Inherited = inherited;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksTaskTool" /> class.
        /// </summary>
        public TasksTaskTool()
        {
        }
    }
}