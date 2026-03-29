
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: computer_20241022
    /// </summary>
    public enum ToolsComputer20241022DefUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        Computer20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsComputer20241022DefUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsComputer20241022DefUpdateType value)
        {
            return value switch
            {
                ToolsComputer20241022DefUpdateType.Computer20241022 => "computer_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsComputer20241022DefUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "computer_20241022" => ToolsComputer20241022DefUpdateType.Computer20241022,
                _ => null,
            };
        }
    }
}