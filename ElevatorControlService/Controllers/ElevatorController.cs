using ElevatorControl.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorControlService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private readonly ILogger<ElevatorController> _logger;
        private readonly IElevatorService _elevatorService = null;

        public ElevatorController(ILogger<ElevatorController> logger, IElevatorService elevatorService)
        {
            _logger = logger;

            if (this._elevatorService == null)
            {
                throw new ArgumentNullException("Eleavor service must be supplied!", nameof(elevatorService));
            }

            this._elevatorService = elevatorService;
        }
    }
}
