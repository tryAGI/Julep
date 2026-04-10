
#nullable enable

namespace Julep
{
    public sealed partial class JulepClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "Http" &&
                    __authorization.Name == "Bearer")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Julep.EndPointAuthorization
            {
                Type = "Http",
                SchemeId = "BearerAuth",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}