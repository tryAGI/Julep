
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item
    {
        /// <summary>
        /// Default Value: image
        /// </summary>
        /// <default>global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType.Image</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemTypeJsonConverter))]
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType Type { get; set; } = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType.Image;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type">
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item(
            global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource source,
            global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType type = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType.Image)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item" /> class.
        /// </summary>
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item FromSource(global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource source)
        {
            return new TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item
            {
                Source = source,
            };
        }

    }
}