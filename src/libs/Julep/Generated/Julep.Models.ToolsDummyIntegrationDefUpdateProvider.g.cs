
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: dummy
    /// </summary>
    public enum ToolsDummyIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Dummy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsDummyIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsDummyIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsDummyIntegrationDefUpdateProvider.Dummy => "dummy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsDummyIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "dummy" => ToolsDummyIntegrationDefUpdateProvider.Dummy,
                _ => null,
            };
        }
    }
}