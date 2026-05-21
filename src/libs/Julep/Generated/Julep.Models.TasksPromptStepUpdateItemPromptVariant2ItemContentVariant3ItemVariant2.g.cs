
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2
    {
        /// <summary>
        /// The image URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2ImageUrl ImageUrl { get; set; }

        /// <summary>
        /// The type (fixed to 'image_url')<br/>
        /// Default Value: image_url
        /// </summary>
        /// <default>global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type.ImageUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2TypeJsonConverter))]
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type Type { get; set; } = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type.ImageUrl;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The image URL
        /// </param>
        /// <param name="type">
        /// The type (fixed to 'image_url')<br/>
        /// Default Value: image_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2(
            global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2ImageUrl imageUrl,
            global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type type = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type.ImageUrl)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2" /> class.
        /// </summary>
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2 FromImageUrl(global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2ImageUrl imageUrl)
        {
            return new TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2
            {
                ImageUrl = imageUrl,
            };
        }

    }
}