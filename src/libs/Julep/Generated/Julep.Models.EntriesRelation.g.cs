
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntriesRelation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Relation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Tail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntriesRelation" /> class.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="relation"></param>
        /// <param name="tail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntriesRelation(
            global::System.Guid head,
            string relation,
            global::System.Guid tail)
        {
            this.Head = head;
            this.Relation = relation ?? throw new global::System.ArgumentNullException(nameof(relation));
            this.Tail = tail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntriesRelation" /> class.
        /// </summary>
        public EntriesRelation()
        {
        }

    }
}