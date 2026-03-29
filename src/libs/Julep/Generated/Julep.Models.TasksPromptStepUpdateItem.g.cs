
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksPromptStepUpdateItem
    {
        /// <summary>
        /// The prompt to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>> Prompt { get; set; }

        /// <summary>
        /// The tools to use for the prompt<br/>
        /// Default Value: all
        /// </summary>
        /// <default>global::Julep.TasksPromptStepUpdateItemTools.All</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksPromptStepUpdateItemTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>> Tools { get; set; } = global::Julep.TasksPromptStepUpdateItemTools.All;

        /// <summary>
        /// The tool choice for the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.TasksPromptStepUpdateItemToolChoice?, global::Julep.ToolsNamedToolChoice>))]
        public global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemToolChoice?, global::Julep.ToolsNamedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        /// Settings for the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Whether to unwrap the output of the prompt step, equivalent to `response.choices[0].message.content`<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unwrap")]
        public bool? Unwrap { get; set; }

        /// <summary>
        /// Whether to auto-run the tool and send the tool results to the model when available.<br/>
        /// (default: false)<br/>
        /// If a tool call is made, the tool's output will be used as the model's input.<br/>
        /// If a tool call is not made, the model's output will be used as the next step's input.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_run_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRunTools { get; set; }

        /// <summary>
        /// Whether to disable caching for the prompt step<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_cache")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableCache { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItem" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to run
        /// </param>
        /// <param name="tools">
        /// The tools to use for the prompt<br/>
        /// Default Value: all
        /// </param>
        /// <param name="autoRunTools">
        /// Whether to auto-run the tool and send the tool results to the model when available.<br/>
        /// (default: false)<br/>
        /// If a tool call is made, the tool's output will be used as the model's input.<br/>
        /// If a tool call is not made, the model's output will be used as the next step's input.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableCache">
        /// Whether to disable caching for the prompt step<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolChoice">
        /// The tool choice for the prompt
        /// </param>
        /// <param name="settings">
        /// Settings for the prompt
        /// </param>
        /// <param name="unwrap">
        /// Whether to unwrap the output of the prompt step, equivalent to `response.choices[0].message.content`<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksPromptStepUpdateItem(
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>> prompt,
            global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>> tools,
            bool autoRunTools,
            bool disableCache,
            global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemToolChoice?, global::Julep.ToolsNamedToolChoice>? toolChoice,
            object? settings,
            bool? unwrap)
        {
            this.Prompt = prompt;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Settings = settings;
            this.Unwrap = unwrap;
            this.AutoRunTools = autoRunTools;
            this.DisableCache = disableCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksPromptStepUpdateItem" /> class.
        /// </summary>
        public TasksPromptStepUpdateItem()
        {
        }
    }
}