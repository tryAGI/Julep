
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: REQUEST_RELEASE
    /// </summary>
    public enum ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        RequestRelease,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseCompleteSessionArgumentsUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus value)
        {
            return value switch
            {
                ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus.RequestRelease => "REQUEST_RELEASE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "REQUEST_RELEASE" => ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus.RequestRelease,
                _ => null,
            };
        }
    }
}