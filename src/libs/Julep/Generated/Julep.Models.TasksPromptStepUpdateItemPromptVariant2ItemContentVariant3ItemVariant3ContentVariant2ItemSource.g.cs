
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource
    {
        /// <summary>
        /// Default Value: base64
        /// </summary>
        /// <default>global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType.Base64</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceTypeJsonConverter))]
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType Type { get; set; } = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType.Base64;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// A valid jinja template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="data">
        /// A valid jinja template.
        /// </param>
        /// <param name="type">
        /// Default Value: base64
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource(
            string mediaType,
            string data,
            global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType type = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType.Base64)
        {
            this.Type = type;
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource" /> class.
        /// </summary>
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource()
        {
        }

    }
}