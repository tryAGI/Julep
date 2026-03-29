#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Bulk delete Docs owned by an Agent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Julep.CommonResourceDeletedResponse>> AgentDocsRouteDeleteBulkAsync(
            global::System.Guid id,

            global::Julep.DocsBulkDeleteDocsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete Docs owned by an Agent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the search<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="deleteAll">
        /// Delete all docs<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Julep.CommonResourceDeletedResponse>> AgentDocsRouteDeleteBulkAsync(
            global::System.Guid id,
            object metadataFilter,
            bool deleteAll,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}