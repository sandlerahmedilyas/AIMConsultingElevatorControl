using ElevatorControl.Contracts.RnR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControl.Contracts.Interfaces
{
    public interface IElevatorService
    {
        /// <summary>
        /// Request to go to floor specified in the parameter
        /// </summary>
        /// <param name="request">The request object containing data required for operation</param>
        /// <returns>A response of the operation</returns>
        RequestElevatorToFloorResponse RequestElevatorToFloor(RequestElevatorToFloorRequest request);


    }
}
