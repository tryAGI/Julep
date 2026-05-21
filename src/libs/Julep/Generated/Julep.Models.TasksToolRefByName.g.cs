
#nullable enable

namespace Julep
{
    /// <summary>
    /// Reference to a tool by name
    /// </summary>
    public sealed partial class TasksToolRefByName
    {
        /// <summary>
        /// Valid python identifier names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksToolRefByName" /> class.
        /// </summary>
        /// <param name="name">
        /// Valid python identifier names
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksToolRefByName(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksToolRefByName" /> class.
        /// </summary>
        public TasksToolRefByName()
        {
        }

    }
}