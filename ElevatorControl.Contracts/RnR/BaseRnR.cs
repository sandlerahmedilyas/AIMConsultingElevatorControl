namespace ElevatorControl.Contracts.RnR
{
    /// <summary>
    /// Base request - extensible in future to add other items to be exposed to parent classes if needed.
    /// </summary>
    public class BaseRequest
    {
    }

    /// <summary>
    /// Base response to all requests. The basic and minimalist information to be stored here such as Success of an operation or a friendly error message
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// Gets or Sets the success of the operation
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets the failure information of a failed operation
        /// </summary>
        public string FailureInformation { get; set; }
    }
}
