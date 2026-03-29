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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DeveloperSecretsRouteListResponse> DeveloperSecretsRouteListAsync(
            global::System.Guid id,
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.DeveloperSecretsRouteListSortBy sortBy = global::Julep.DeveloperSecretsRouteListSortBy.CreatedAt,
            global::Julep.DeveloperSecretsRouteListDirection direction = global::Julep.DeveloperSecretsRouteListDirection.Asc,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}