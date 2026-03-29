
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBrowserbaseListSessionsArguments
    {
        /// <summary>
        /// The status of the sessions to list (Available options: RUNNING, ERROR, TIMED_OUT, COMPLETED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseListSessionsArgumentsStatusJsonConverter))]
        public global::Julep.ToolsBrowserbaseListSessionsArgumentsStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseListSessionsArguments" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the sessions to list (Available options: RUNNING, ERROR, TIMED_OUT, COMPLETED)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseListSessionsArguments(
            global::Julep.ToolsBrowserbaseListSessionsArgumentsStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseListSessionsArguments" /> class.
        /// </summary>
        public ToolsBrowserbaseListSessionsArguments()
        {
        }
    }
}