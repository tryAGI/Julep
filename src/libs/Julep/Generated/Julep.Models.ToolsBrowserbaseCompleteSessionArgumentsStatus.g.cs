
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: REQUEST_RELEASE
    /// </summary>
    public enum ToolsBrowserbaseCompleteSessionArgumentsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        RequestRelease,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseCompleteSessionArgumentsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseCompleteSessionArgumentsStatus value)
        {
            return value switch
            {
                ToolsBrowserbaseCompleteSessionArgumentsStatus.RequestRelease => "REQUEST_RELEASE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseCompleteSessionArgumentsStatus? ToEnum(string value)
        {
            return value switch
            {
                "REQUEST_RELEASE" => ToolsBrowserbaseCompleteSessionArgumentsStatus.RequestRelease,
                _ => null,
            };
        }
    }
}