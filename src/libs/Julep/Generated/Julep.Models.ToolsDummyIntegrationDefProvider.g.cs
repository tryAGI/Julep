
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: dummy
    /// </summary>
    public enum ToolsDummyIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Dummy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsDummyIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsDummyIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsDummyIntegrationDefProvider.Dummy => "dummy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsDummyIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "dummy" => ToolsDummyIntegrationDefProvider.Dummy,
                _ => null,
            };
        }
    }
}