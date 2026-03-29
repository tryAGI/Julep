#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Update an existing Execution
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ExecutionsExecution> ExecutionsRouteUpdateAsync(
            global::System.Guid id,

            global::Julep.ExecutionsUpdateExecutionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}