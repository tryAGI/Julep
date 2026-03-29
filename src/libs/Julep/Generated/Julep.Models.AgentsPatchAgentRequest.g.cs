
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for patching a agent
    /// </summary>
    public sealed partial class AgentsPatchAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Project canonical name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Canonical name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// About the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about")]
        public string? About { get; set; }

        /// <summary>
        /// Model name to use (gpt-4-turbo, gemini-nano etc)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Instructions for the agent<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? Instructions { get; set; }

        /// <summary>
        /// Default settings for all sessions created by this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_settings")]
        public object? DefaultSettings { get; set; }

        /// <summary>
        /// Default system template for all sessions created by this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_system_template")]
        public string? DefaultSystemTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPatchAgentRequest" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="name">
        /// Name of the agent
        /// </param>
        /// <param name="project">
        /// Project canonical name of the agent
        /// </param>
        /// <param name="canonicalName">
        /// Canonical name of the agent
        /// </param>
        /// <param name="about">
        /// About the agent
        /// </param>
        /// <param name="model">
        /// Model name to use (gpt-4-turbo, gemini-nano etc)
        /// </param>
        /// <param name="instructions">
        /// Instructions for the agent<br/>
        /// Default Value: []
        /// </param>
        /// <param name="defaultSettings">
        /// Default settings for all sessions created by this agent
        /// </param>
        /// <param name="defaultSystemTemplate">
        /// Default system template for all sessions created by this agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsPatchAgentRequest(
            object? metadata,
            string? name,
            string? project,
            string? canonicalName,
            string? about,
            string? model,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? instructions,
            object? defaultSettings,
            string? defaultSystemTemplate)
        {
            this.Metadata = metadata;
            this.Name = name;
            this.Project = project;
            this.CanonicalName = canonicalName;
            this.About = about;
            this.Model = model;
            this.Instructions = instructions;
            this.DefaultSettings = defaultSettings;
            this.DefaultSystemTemplate = defaultSystemTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPatchAgentRequest" /> class.
        /// </summary>
        public AgentsPatchAgentRequest()
        {
        }
    }
}