
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item
    {
        /// <summary>
        /// A valid jinja template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemTypeJsonConverter))]
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType Type { get; set; } = global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item" /> class.
        /// </summary>
        /// <param name="text">
        /// A valid jinja template.
        /// </param>
        /// <param name="type">
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item(
            string text,
            global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType type = global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item" /> class.
        /// </summary>
        public TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item FromText(string text)
        {
            return new TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item
            {
                Text = text,
            };
        }

    }
}