
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksWaitForInputStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        WaitForInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksWaitForInputStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksWaitForInputStepEnumKind value)
        {
            return value switch
            {
                TasksWaitForInputStepEnumKind.WaitForInput => "wait_for_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksWaitForInputStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "wait_for_input" => TasksWaitForInputStepEnumKind.WaitForInput,
                _ => null,
            };
        }
    }
}