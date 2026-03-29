#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create a new resource owned by the given parent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AgentToolsRouteCreateAsync(
            global::System.Guid id,

            global::Julep.AgentsCreateAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new resource owned by the given parent
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AgentToolsRouteCreateAsync(
            global::System.Guid id,
            string name,
            string about,
            string model,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> instructions,
            string defaultSystemTemplate,
            object? metadata = default,
            string? project = default,
            string? canonicalName = default,
            object? defaultSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}