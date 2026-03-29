
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1
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
        /// <default>global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1TypeJsonConverter))]
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type Type { get; set; } = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1" /> class.
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
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1(
            string text,
            global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type type = global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1" /> class.
        /// </summary>
        public TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1()
        {
        }
    }
}