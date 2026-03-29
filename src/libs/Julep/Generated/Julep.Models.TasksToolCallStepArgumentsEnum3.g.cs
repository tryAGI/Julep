
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksToolCallStepArgumentsEnum3
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksToolCallStepArgumentsEnum3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksToolCallStepArgumentsEnum3 value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksToolCallStepArgumentsEnum3? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}