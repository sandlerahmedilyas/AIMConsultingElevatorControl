using ElevatorControl.Contracts.Interfaces;
using ElevatorControl.Contracts.RnR;
using Microsoft.Extensions.Logging;
using System;

namespace ElevatorControl.Implementation
{
    public class ElevatorService : IElevatorService
    {
        private readonly ILogger<ElevatorService> _logger;

        public ElevatorService(ILogger<ElevatorService> logger)
        {
            this._logger = logger;
        }

        public RequestElevatorToFloorResponse RequestElevatorToFloor(RequestElevatorToFloorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
