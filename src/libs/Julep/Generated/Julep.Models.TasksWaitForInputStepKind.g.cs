
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: wait_for_input<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksWaitForInputStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        WaitForInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksWaitForInputStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksWaitForInputStepKind value)
        {
            return value switch
            {
                TasksWaitForInputStepKind.WaitForInput => "wait_for_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksWaitForInputStepKind? ToEnum(string value)
        {
            return value switch
            {
                "wait_for_input" => TasksWaitForInputStepKind.WaitForInput,
                _ => null,
            };
        }
    }
}