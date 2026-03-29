
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "unstructured"<br/>
    /// Default Value: unstructured
    /// </summary>
    public enum ToolsUnstructuredIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Unstructured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsUnstructuredIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsUnstructuredIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsUnstructuredIntegrationDefUpdateProvider.Unstructured => "unstructured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsUnstructuredIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "unstructured" => ToolsUnstructuredIntegrationDefUpdateProvider.Unstructured,
                _ => null,
            };
        }
    }
}