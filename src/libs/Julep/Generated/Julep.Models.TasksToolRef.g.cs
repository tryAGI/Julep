
#nullable enable

namespace Julep
{
    /// <summary>
    /// Reference to a tool
    /// </summary>
    public sealed partial class TasksToolRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksToolRefById, global::Julep.TasksToolRefByName>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.TasksToolRefById, global::Julep.TasksToolRefByName> Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksToolRef" /> class.
        /// </summary>
        /// <param name="ref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksToolRef(
            global::Julep.AnyOf<global::Julep.TasksToolRefById, global::Julep.TasksToolRefByName> @ref)
        {
            this.Ref = @ref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksToolRef" /> class.
        /// </summary>
        public TasksToolRef()
        {
        }
    }
}