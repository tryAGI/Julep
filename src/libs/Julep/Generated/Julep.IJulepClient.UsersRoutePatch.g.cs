#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Update an existing user by id (merge with existing values)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.UsersUser> UsersRoutePatchAsync(
            global::System.Guid id,

            global::Julep.UsersPatchUserRequest request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing user by id (merge with existing values)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AutoSDKHttpResponse<global::Julep.UsersUser>> UsersRoutePatchAsResponseAsync(
            global::System.Guid id,

            global::Julep.UsersPatchUserRequest request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing user by id (merge with existing values)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="name">
        /// Name of the user
        /// </param>
        /// <param name="about">
        /// About the user
        /// </param>
        /// <param name="project">
        /// Project canonical name of the user
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.UsersUser> UsersRoutePatchAsync(
            global::System.Guid id,
            object? metadata = default,
            string? name = default,
            string? about = default,
            string? project = default,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}