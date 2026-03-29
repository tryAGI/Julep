
#nullable enable

namespace Julep
{
    /// <summary>
    /// The HTTP method to use
    /// </summary>
    public enum ToolsApiCallDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Connect,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Head,
        /// <summary>
        /// 
        /// </summary>
        Options,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsApiCallDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsApiCallDefUpdateMethod value)
        {
            return value switch
            {
                ToolsApiCallDefUpdateMethod.Connect => "CONNECT",
                ToolsApiCallDefUpdateMethod.Delete => "DELETE",
                ToolsApiCallDefUpdateMethod.Get => "GET",
                ToolsApiCallDefUpdateMethod.Head => "HEAD",
                ToolsApiCallDefUpdateMethod.Options => "OPTIONS",
                ToolsApiCallDefUpdateMethod.Patch => "PATCH",
                ToolsApiCallDefUpdateMethod.Post => "POST",
                ToolsApiCallDefUpdateMethod.Put => "PUT",
                ToolsApiCallDefUpdateMethod.Trace => "TRACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsApiCallDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "CONNECT" => ToolsApiCallDefUpdateMethod.Connect,
                "DELETE" => ToolsApiCallDefUpdateMethod.Delete,
                "GET" => ToolsApiCallDefUpdateMethod.Get,
                "HEAD" => ToolsApiCallDefUpdateMethod.Head,
                "OPTIONS" => ToolsApiCallDefUpdateMethod.Options,
                "PATCH" => ToolsApiCallDefUpdateMethod.Patch,
                "POST" => ToolsApiCallDefUpdateMethod.Post,
                "PUT" => ToolsApiCallDefUpdateMethod.Put,
                "TRACE" => ToolsApiCallDefUpdateMethod.Trace,
                _ => null,
            };
        }
    }
}