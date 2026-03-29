
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: bash_20241022
    /// </summary>
    public enum ToolsBash20241022DefType
    {
        /// <summary>
        /// 
        /// </summary>
        Bash20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBash20241022DefTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBash20241022DefType value)
        {
            return value switch
            {
                ToolsBash20241022DefType.Bash20241022 => "bash_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBash20241022DefType? ToEnum(string value)
        {
            return value switch
            {
                "bash_20241022" => ToolsBash20241022DefType.Bash20241022,
                _ => null,
            };
        }
    }
}