
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksWaitForInputInfo
    {
        /// <summary>
        /// Any additional info or data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Info { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksWaitForInputInfo" /> class.
        /// </summary>
        /// <param name="info">
        /// Any additional info or data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksWaitForInputInfo(
            object info)
        {
            this.Info = info ?? throw new global::System.ArgumentNullException(nameof(info));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksWaitForInputInfo" /> class.
        /// </summary>
        public TasksWaitForInputInfo()
        {
        }

    }
}