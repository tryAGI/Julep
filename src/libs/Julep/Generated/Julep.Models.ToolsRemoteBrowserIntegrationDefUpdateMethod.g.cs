
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: perform_action
    /// </summary>
    public enum ToolsRemoteBrowserIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        PerformAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsRemoteBrowserIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsRemoteBrowserIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsRemoteBrowserIntegrationDefUpdateMethod.PerformAction => "perform_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsRemoteBrowserIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "perform_action" => ToolsRemoteBrowserIntegrationDefUpdateMethod.PerformAction,
                _ => null,
            };
        }
    }
}