namespace ElevatorControl.Contracts.RnR
{
    public sealed class RequestElevatorToFloorRequest : BaseRequest
    {
        /// <summary>
        /// Gets the Floor to go to
        /// </summary>
        public int ToFloor { get; private set; }

        public RequestElevatorToFloorRequest(int gotoFloor)
        {
            this.ToFloor = gotoFloor;
        }
    }

    /// <summary>
    /// Class that returns a response from a request. Any core information is in the base class.
    /// </summary>
    public sealed class RequestElevatorToFloorResponse : BaseResponse
    {

    }
}
