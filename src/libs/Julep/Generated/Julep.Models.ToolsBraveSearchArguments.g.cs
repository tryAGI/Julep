
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Brave Search
    /// </summary>
    public sealed partial class ToolsBraveSearchArguments
    {
        /// <summary>
        /// The search query for searching with Brave
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveSearchArguments" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query for searching with Brave
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBraveSearchArguments(
            string query)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveSearchArguments" /> class.
        /// </summary>
        public ToolsBraveSearchArguments()
        {
        }
    }
}