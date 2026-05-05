#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// List Docs owned by a User
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
        /// <param name="includeEmbeddings">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.UserDocsRouteListResponse> UserDocsRouteListAsync(
            global::System.Guid id,
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.UserDocsRouteListSortBy sortBy = global::Julep.UserDocsRouteListSortBy.CreatedAt,
            global::Julep.UserDocsRouteListDirection direction = global::Julep.UserDocsRouteListDirection.Asc,
            bool? includeEmbeddings = default,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Docs owned by a User
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
        /// <param name="includeEmbeddings">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AutoSDKHttpResponse<global::Julep.UserDocsRouteListResponse>> UserDocsRouteListAsResponseAsync(
            global::System.Guid id,
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.UserDocsRouteListSortBy sortBy = global::Julep.UserDocsRouteListSortBy.CreatedAt,
            global::Julep.UserDocsRouteListDirection direction = global::Julep.UserDocsRouteListDirection.Asc,
            bool? includeEmbeddings = default,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}