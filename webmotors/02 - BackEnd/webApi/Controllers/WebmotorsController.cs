using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using WebMotors.Domain.Core.Shared;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebmotorsController : ControllerBase
    {
        private readonly IWebMotorsFacade _webMotorsFacade;
        private readonly ILogger<WebmotorsController> _logger;

        public WebmotorsController(IWebMotorsFacade webMotorsFacade, ILogger<WebmotorsController> logger)
        {
            _webMotorsFacade = webMotorsFacade;
            _logger = logger;
        }

        [HttpGet("Make")]
        public ActionResult<IEnumerable<string>> Make() 
        {
            try
            {
                _logger.LogInformation("Chamou a Lista Make");

                var result = _webMotorsFacade.GetMake();
                return new OkObjectResult(result);
            }
            catch (ArgumentNullException e)
            {
                _logger.LogError(e.Message);
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Model/{makeId}")]
        public ActionResult<IEnumerable<string>> Model(int makeId)
        {
            try
            {
                _logger.LogInformation("Chamou a Lista Model");

                var result = _webMotorsFacade.GetModel(makeId);
                return new OkObjectResult(result);
            }
            catch (ArgumentNullException e)
            {
                _logger.LogError(e.Message);
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Version/{modelId}")]
        public ActionResult<IEnumerable<string>> Version(int modelId)
        {
            try
            {
                _logger.LogInformation("Chamou a Lista Version");

                var result = _webMotorsFacade.GetVersion(modelId);
                return new OkObjectResult(result);
            }
            catch (ArgumentNullException e)
            {
                _logger.LogError(e.Message);
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Vehicles/{page}")]
        public ActionResult<IEnumerable<string>> Vehicles(int page) 
        {
            {
                try
                {
                    _logger.LogInformation("Chamou a Lista Vehicles");

                    var result = _webMotorsFacade.GetVehicles(page);
                    return new OkObjectResult(result);
                }
                catch (ArgumentNullException e)
                {
                    _logger.LogError(e.Message);
                    return NotFound(e.Message);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return BadRequest(e.Message);
                }
            }
        }
    }
}
