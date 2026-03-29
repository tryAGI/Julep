#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Get a response by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ResponsesResponse> ResponsesRouteGetResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::Julep.ResponsesIncludable>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}