#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// List all available models
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AgentsListModelsResponse> AgentsRouteListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}