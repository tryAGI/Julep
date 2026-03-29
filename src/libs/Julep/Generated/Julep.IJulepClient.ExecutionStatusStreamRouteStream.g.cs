#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Stream the status of an execution
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nextToken">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> ExecutionStatusStreamRouteStreamAsync(
            global::System.Guid id,
            string? nextToken,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}