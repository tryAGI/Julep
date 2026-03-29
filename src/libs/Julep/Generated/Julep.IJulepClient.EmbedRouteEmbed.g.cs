#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Embed a query for search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsEmbedQueryResponse> EmbedRouteEmbedAsync(

            global::Julep.EmbedRouteEmbedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embed a query for search
        /// </summary>
        /// <param name="body"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsEmbedQueryResponse> EmbedRouteEmbedAsync(
            global::Julep.AnyOf<global::Julep.DocsSingleEmbedQueryRequest, global::Julep.DocsMultipleEmbedQueryRequest> body,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}