
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call<br/>
    /// Default Value: create_context
    /// </summary>
    public enum ToolsBrowserbaseContextIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CreateContext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseContextIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseContextIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseContextIntegrationDefMethod.CreateContext => "create_context",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseContextIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "create_context" => ToolsBrowserbaseContextIntegrationDefMethod.CreateContext,
                _ => null,
            };
        }
    }
}