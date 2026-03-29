
#nullable enable

namespace Julep
{
    /// <summary>
    /// The HTTP method to use
    /// </summary>
    public enum ToolsApiCallDefMethod
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
    public static class ToolsApiCallDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsApiCallDefMethod value)
        {
            return value switch
            {
                ToolsApiCallDefMethod.Connect => "CONNECT",
                ToolsApiCallDefMethod.Delete => "DELETE",
                ToolsApiCallDefMethod.Get => "GET",
                ToolsApiCallDefMethod.Head => "HEAD",
                ToolsApiCallDefMethod.Options => "OPTIONS",
                ToolsApiCallDefMethod.Patch => "PATCH",
                ToolsApiCallDefMethod.Post => "POST",
                ToolsApiCallDefMethod.Put => "PUT",
                ToolsApiCallDefMethod.Trace => "TRACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsApiCallDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "CONNECT" => ToolsApiCallDefMethod.Connect,
                "DELETE" => ToolsApiCallDefMethod.Delete,
                "GET" => ToolsApiCallDefMethod.Get,
                "HEAD" => ToolsApiCallDefMethod.Head,
                "OPTIONS" => ToolsApiCallDefMethod.Options,
                "PATCH" => ToolsApiCallDefMethod.Patch,
                "POST" => ToolsApiCallDefMethod.Post,
                "PUT" => ToolsApiCallDefMethod.Put,
                "TRACE" => ToolsApiCallDefMethod.Trace,
                _ => null,
            };
        }
    }
}