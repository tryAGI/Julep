#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create a new secret
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.SecretsSecret> AgentSecretsRouteCreateAsync(
            global::System.Guid id,

            global::Julep.SecretsCreateSecretRequest request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new secret
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AutoSDKHttpResponse<global::Julep.SecretsSecret>> AgentSecretsRouteCreateAsResponseAsync(
            global::System.Guid id,

            global::Julep.SecretsCreateSecretRequest request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new secret
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="name">
        /// Name of the secret
        /// </param>
        /// <param name="description">
        /// Description of what the secret is used for
        /// </param>
        /// <param name="value">
        /// The decrypted secret value
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.SecretsSecret> AgentSecretsRouteCreateAsync(
            global::System.Guid id,
            string name,
            string value,
            object? metadata = default,
            string? description = default,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}