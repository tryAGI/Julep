
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call<br/>
    /// Default Value: create_context
    /// </summary>
    public enum ToolsBrowserbaseContextIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CreateContext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseContextIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseContextIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseContextIntegrationDefUpdateMethod.CreateContext => "create_context",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseContextIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "create_context" => ToolsBrowserbaseContextIntegrationDefUpdateMethod.CreateContext,
                _ => null,
            };
        }
    }
}