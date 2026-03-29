#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Delete a Doc for this Agent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.CommonResourceDeletedResponse> AgentDocsRouteDeleteAsync(
            global::System.Guid id,
            global::System.Guid childId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}