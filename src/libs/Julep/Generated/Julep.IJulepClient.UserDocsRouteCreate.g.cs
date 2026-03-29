#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create a Doc for this User
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsDoc> UserDocsRouteCreateAsync(
            global::System.Guid id,

            global::Julep.DocsCreateDocRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Doc for this User
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="title">
        /// Title describing what this document contains
        /// </param>
        /// <param name="content">
        /// Contents of the document. Each string is limited to 30k characters.
        /// </param>
        /// <param name="embedInstruction">
        /// Instruction for the embedding model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.DocsDoc> UserDocsRouteCreateAsync(
            global::System.Guid id,
            string title,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> content,
            object? metadata = default,
            string? embedInstruction = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}