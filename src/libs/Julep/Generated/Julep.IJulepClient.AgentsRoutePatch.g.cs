#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Update an existing Agent by id (merges with existing values)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AgentsAgent> AgentsRoutePatchAsync(
            global::System.Guid id,

            global::Julep.AgentsPatchAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing Agent by id (merges with existing values)
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
        global::System.Threading.Tasks.Task<global::Julep.AgentsAgent> AgentsRoutePatchAsync(
            global::System.Guid id,
            object? metadata = default,
            string? name = default,
            string? project = default,
            string? canonicalName = default,
            string? about = default,
            string? model = default,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? instructions = default,
            object? defaultSettings = default,
            string? defaultSystemTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}