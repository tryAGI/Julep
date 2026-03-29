
#nullable enable

namespace Julep
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum ExecutionsTransitionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Finish,
        /// <summary>
        /// 
        /// </summary>
        FinishBranch,
        /// <summary>
        /// 
        /// </summary>
        Init,
        /// <summary>
        /// 
        /// </summary>
        InitBranch,
        /// <summary>
        /// 
        /// </summary>
        Resume,
        /// <summary>
        /// 
        /// </summary>
        Step,
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsTransitionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsTransitionEventType value)
        {
            return value switch
            {
                ExecutionsTransitionEventType.Cancelled => "cancelled",
                ExecutionsTransitionEventType.Error => "error",
                ExecutionsTransitionEventType.Finish => "finish",
                ExecutionsTransitionEventType.FinishBranch => "finish_branch",
                ExecutionsTransitionEventType.Init => "init",
                ExecutionsTransitionEventType.InitBranch => "init_branch",
                ExecutionsTransitionEventType.Resume => "resume",
                ExecutionsTransitionEventType.Step => "step",
                ExecutionsTransitionEventType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsTransitionEventType? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExecutionsTransitionEventType.Cancelled,
                "error" => ExecutionsTransitionEventType.Error,
                "finish" => ExecutionsTransitionEventType.Finish,
                "finish_branch" => ExecutionsTransitionEventType.FinishBranch,
                "init" => ExecutionsTransitionEventType.Init,
                "init_branch" => ExecutionsTransitionEventType.InitBranch,
                "resume" => ExecutionsTransitionEventType.Resume,
                "step" => ExecutionsTransitionEventType.Step,
                "wait" => ExecutionsTransitionEventType.Wait,
                _ => null,
            };
        }
    }
}