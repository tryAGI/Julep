
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksCaseThenCase
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksCaseThenCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCaseThenCase value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCaseThenCase? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}