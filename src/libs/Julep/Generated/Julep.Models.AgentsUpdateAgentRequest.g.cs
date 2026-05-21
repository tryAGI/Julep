
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for updating a agent
    /// </summary>
    public sealed partial class AgentsUpdateAgentRequest
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string About { get; set; }

        /// <summary>
        /// Model name to use (gpt-4-turbo, gemini-nano etc)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Instructions for the agent<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> Instructions { get; set; }

        /// <summary>
        /// Default settings for all sessions created by this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_settings")]
        public object? DefaultSettings { get; set; }

        /// <summary>
        /// Default system template for all sessions created by this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultSystemTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsUpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the agent
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
        /// <param name="defaultSystemTemplate">
        /// Default system template for all sessions created by this agent
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="project">
        /// Project canonical name of the agent
        /// </param>
        /// <param name="canonicalName">
        /// Canonical name of the agent
        /// </param>
        /// <param name="defaultSettings">
        /// Default settings for all sessions created by this agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsUpdateAgentRequest(
            string name,
            string about,
            string model,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> instructions,
            string defaultSystemTemplate,
            object? metadata,
            string? project,
            string? canonicalName,
            object? defaultSettings)
        {
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Project = project;
            this.CanonicalName = canonicalName;
            this.About = about ?? throw new global::System.ArgumentNullException(nameof(about));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Instructions = instructions;
            this.DefaultSettings = defaultSettings;
            this.DefaultSystemTemplate = defaultSystemTemplate ?? throw new global::System.ArgumentNullException(nameof(defaultSystemTemplate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsUpdateAgentRequest" /> class.
        /// </summary>
        public AgentsUpdateAgentRequest()
        {
        }

    }
}