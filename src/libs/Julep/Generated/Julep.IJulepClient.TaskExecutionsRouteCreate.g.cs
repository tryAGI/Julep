#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create an execution for the given task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ExecutionsExecution> TaskExecutionsRouteCreateAsync(
            global::System.Guid id,

            global::Julep.ExecutionsCreateExecutionRequest request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an execution for the given task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AutoSDKHttpResponse<global::Julep.ExecutionsExecution>> TaskExecutionsRouteCreateAsResponseAsync(
            global::System.Guid id,

            global::Julep.ExecutionsCreateExecutionRequest request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an execution for the given task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input">
        /// The input to the execution
        /// </param>
        /// <param name="output">
        /// The output of the execution if it succeeded
        /// </param>
        /// <param name="error">
        /// The error of the execution if it failed
        /// </param>
        /// <param name="transitionCount">
        /// The number of transitions in this execution
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ExecutionsExecution> TaskExecutionsRouteCreateAsync(
            global::System.Guid id,
            object input,
            object? output = default,
            string? error = default,
            byte? transitionCount = default,
            object? metadata = default,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}