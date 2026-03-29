#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Resume an execution with a task token
        /// </summary>
        /// <param name="taskToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ExecutionsExecution> ExecutionsRouteResumeWithTaskTokenAsync(
            string taskToken,

            global::Julep.ExecutionsTaskTokenResumeExecutionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume an execution with a task token
        /// </summary>
        /// <param name="taskToken"></param>
        /// <param name="status">
        /// Default Value: running
        /// </param>
        /// <param name="input">
        /// The input to resume the execution with
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ExecutionsExecution> ExecutionsRouteResumeWithTaskTokenAsync(
            string taskToken,
            global::Julep.ExecutionsTaskTokenResumeExecutionRequestStatus status = global::Julep.ExecutionsTaskTokenResumeExecutionRequestStatus.Running,
            object? input = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}