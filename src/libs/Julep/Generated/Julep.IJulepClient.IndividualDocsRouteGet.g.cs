#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Get Doc by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeEmbeddings">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsDoc> IndividualDocsRouteGetAsync(
            global::System.Guid id,
            bool? includeEmbeddings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}