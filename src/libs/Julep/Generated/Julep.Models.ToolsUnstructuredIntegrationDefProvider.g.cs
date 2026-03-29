
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "unstructured"<br/>
    /// Default Value: unstructured
    /// </summary>
    public enum ToolsUnstructuredIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Unstructured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsUnstructuredIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsUnstructuredIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsUnstructuredIntegrationDefProvider.Unstructured => "unstructured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsUnstructuredIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "unstructured" => ToolsUnstructuredIntegrationDefProvider.Unstructured,
                _ => null,
            };
        }
    }
}