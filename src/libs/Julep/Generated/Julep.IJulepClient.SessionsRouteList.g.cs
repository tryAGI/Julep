#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// List sessions (paginated)
        /// </summary>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.SessionsRouteListResponse> SessionsRouteListAsync(
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.SessionsRouteListSortBy sortBy = global::Julep.SessionsRouteListSortBy.CreatedAt,
            global::Julep.SessionsRouteListDirection direction = global::Julep.SessionsRouteListDirection.Asc,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}