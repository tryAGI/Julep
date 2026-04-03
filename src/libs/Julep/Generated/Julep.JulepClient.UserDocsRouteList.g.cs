
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {
        partial void PrepareUserDocsRouteListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref int limit,
            ref int offset,
            ref global::Julep.UserDocsRouteListSortBy sortBy,
            ref global::Julep.UserDocsRouteListDirection direction,
            object metadataFilter,
            ref bool? includeEmbeddings);
        partial void PrepareUserDocsRouteListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            int limit,
            int offset,
            global::Julep.UserDocsRouteListSortBy sortBy,
            global::Julep.UserDocsRouteListDirection direction,
            object metadataFilter,
            bool? includeEmbeddings);
        partial void ProcessUserDocsRouteListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserDocsRouteListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Docs owned by a User
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit">
        /// Limit the number of results
        /// </param>
        /// <param name="offset">
        /// Offset to apply to the results
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: asc
        /// </param>
        /// <param name="metadataFilter">
        /// Default Value: {}
        /// </param>
        /// <param name="includeEmbeddings">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.UserDocsRouteListResponse> UserDocsRouteListAsync(
            global::System.Guid id,
            int limit,
            int offset,
            object metadataFilter,
            global::Julep.UserDocsRouteListSortBy sortBy = global::Julep.UserDocsRouteListSortBy.CreatedAt,
            global::Julep.UserDocsRouteListDirection direction = global::Julep.UserDocsRouteListDirection.Asc,
            bool? includeEmbeddings = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUserDocsRouteListArguments(
                httpClient: HttpClient,
                id: ref id,
                limit: ref limit,
                offset: ref offset,
                sortBy: ref sortBy,
                direction: ref direction,
                metadataFilter: metadataFilter,
                includeEmbeddings: ref includeEmbeddings);

            var __pathBuilder = new global::Julep.PathBuilder(
                path: $"/users/{id}/docs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("limit", limit.ToString()!)
                .AddRequiredParameter("offset", offset.ToString()!)
                .AddRequiredParameter("sort_by", sortBy.ToValueString())
                .AddRequiredParameter("direction", direction.ToValueString())
                .AddRequiredParameter("metadata_filter", metadataFilter.ToString()!)
                .AddOptionalParameter("include_embeddings", includeEmbeddings?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUserDocsRouteListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                limit: limit,
                offset: offset,
                sortBy: sortBy,
                direction: direction,
                metadataFilter: metadataFilter,
                includeEmbeddings: includeEmbeddings);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUserDocsRouteListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUserDocsRouteListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Julep.UserDocsRouteListResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Julep.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Julep.UserDocsRouteListResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Julep.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}