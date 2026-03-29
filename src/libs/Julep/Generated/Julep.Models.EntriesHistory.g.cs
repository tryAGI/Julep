
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntriesHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.EntriesEntry> Entries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.EntriesRelation> Relations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntriesHistory" /> class.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="relations"></param>
        /// <param name="sessionId">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntriesHistory(
            global::System.Collections.Generic.IList<global::Julep.EntriesEntry> entries,
            global::System.Collections.Generic.IList<global::Julep.EntriesRelation> relations,
            global::System.Guid sessionId = default!,
            global::System.DateTime createdAt = default!)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.Relations = relations ?? throw new global::System.ArgumentNullException(nameof(relations));
            this.SessionId = sessionId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntriesHistory" /> class.
        /// </summary>
        public EntriesHistory()
        {
        }
    }
}