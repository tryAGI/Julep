#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create or update a Project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ProjectsProject> ProjectsRouteCreateOrUpdateAsync(
            global::System.Guid id,

            global::Julep.ProjectsUpdateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a Project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="canonicalName">
        /// Canonical name of the project (unique per developer)
        /// </param>
        /// <param name="name">
        /// Display name of the project
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ProjectsProject> ProjectsRouteCreateOrUpdateAsync(
            global::System.Guid id,
            string name,
            object? metadata = default,
            string? canonicalName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}