#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Search Docs owned by an Agent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsDocSearchResponse> AgentsDocsSearchRouteSearchAsync(
            global::System.Guid id,

            global::Julep.AgentsDocsSearchRouteSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Docs owned by an Agent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsDocSearchResponse> AgentsDocsSearchRouteSearchAsync(
            global::System.Guid id,
            global::Julep.AnyOf<global::Julep.DocsVectorDocSearchRequest, global::Julep.DocsTextOnlyDocSearchRequest, global::Julep.DocsHybridDocSearchRequest> body,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}