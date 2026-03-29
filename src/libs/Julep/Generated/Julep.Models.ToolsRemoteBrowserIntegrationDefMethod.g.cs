
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: perform_action
    /// </summary>
    public enum ToolsRemoteBrowserIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        PerformAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsRemoteBrowserIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsRemoteBrowserIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsRemoteBrowserIntegrationDefMethod.PerformAction => "perform_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsRemoteBrowserIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "perform_action" => ToolsRemoteBrowserIntegrationDefMethod.PerformAction,
                _ => null,
            };
        }
    }
}