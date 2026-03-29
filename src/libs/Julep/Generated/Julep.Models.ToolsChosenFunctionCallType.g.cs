
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsChosenFunctionCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsChosenFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsChosenFunctionCallType value)
        {
            return value switch
            {
                ToolsChosenFunctionCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsChosenFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolsChosenFunctionCallType.Function,
                _ => null,
            };
        }
    }
}