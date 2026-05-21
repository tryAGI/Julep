#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// List secrets (paginated)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit">
        /// Limit the number of results
        /// </param>
        /// <param name="offset">
        /// Offset to apply to the results
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: asc
        /// </param>
        /// <param name="metadataFilter">
        /// Default Value: {}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AgentSecretsRouteListResponse> AgentSecretsRouteListAsync(
            global::System.Guid id,
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.AgentSecretsRouteListSortBy sortBy = global::Julep.AgentSecretsRouteListSortBy.CreatedAt,
            global::Julep.AgentSecretsRouteListDirection direction = global::Julep.AgentSecretsRouteListDirection.Asc,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List secrets (paginated)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit">
        /// Limit the number of results
        /// </param>
        /// <param name="offset">
        /// Offset to apply to the results
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: asc
        /// </param>
        /// <param name="metadataFilter">
        /// Default Value: {}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AutoSDKHttpResponse<global::Julep.AgentSecretsRouteListResponse>> AgentSecretsRouteListAsResponseAsync(
            global::System.Guid id,
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.AgentSecretsRouteListSortBy sortBy = global::Julep.AgentSecretsRouteListSortBy.CreatedAt,
            global::Julep.AgentSecretsRouteListDirection direction = global::Julep.AgentSecretsRouteListDirection.Asc,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}