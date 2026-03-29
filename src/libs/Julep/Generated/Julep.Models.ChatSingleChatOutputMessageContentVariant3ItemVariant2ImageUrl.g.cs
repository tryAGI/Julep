
#nullable enable

namespace Julep
{
    /// <summary>
    /// The image URL
    /// </summary>
    public sealed partial class ChatSingleChatOutputMessageContentVariant3ItemVariant2ImageUrl
    {
        /// <summary>
        /// Image URL or base64 data url (e.g. `data:image/jpeg;base64,&lt;the base64 encoded image&gt;`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The detail level of the image<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::Julep.EntriesImageDetail.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.EntriesImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.EntriesImageDetail Detail { get; set; } = global::Julep.EntriesImageDetail.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSingleChatOutputMessageContentVariant3ItemVariant2ImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Image URL or base64 data url (e.g. `data:image/jpeg;base64,&lt;the base64 encoded image&gt;`)
        /// </param>
        /// <param name="detail">
        /// The detail level of the image<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSingleChatOutputMessageContentVariant3ItemVariant2ImageUrl(
            string url,
            global::Julep.EntriesImageDetail detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSingleChatOutputMessageContentVariant3ItemVariant2ImageUrl" /> class.
        /// </summary>
        public ChatSingleChatOutputMessageContentVariant3ItemVariant2ImageUrl()
        {
        }
    }
}