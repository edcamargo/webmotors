using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Web.Http;
using WebMotors.Domain.Core.Interfaces.Services;
using WebMotors.Domain.Entities;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementWebMotorsService _announcementWebMotorsService;
        private readonly ILogger<AnnouncementController> _logger;
        public AnnouncementController(IAnnouncementWebMotorsService announcementWebMotorsService, ILogger<AnnouncementController> logger)
        {
            _announcementWebMotorsService = announcementWebMotorsService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                _logger.LogInformation("Chamou a Lista total");

                var _announcementWebMotors = _announcementWebMotorsService.GetAll();
                return new OkObjectResult(_announcementWebMotors);
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

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                _logger.LogInformation("Chamou a Lista por Id");

                var _announcementWebMotors = _announcementWebMotorsService.GetById(id);
                return new OkObjectResult(_announcementWebMotors);
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

        [HttpPost]
        public IActionResult Post([FromBody] AnnouncementWebMotors announcementWebmotors)
        {
            try
            {
                _logger.LogInformation("Chamou o Post");

                if (announcementWebmotors == null)
                    return BadRequest();

                var _announcementWebmotors = _announcementWebMotorsService.Add(announcementWebmotors);

                return Created("/", "Created");
            }
            catch (ArgumentNullException e)
            {
                _logger.LogError(e.Message);
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message + " | " + e.InnerException);
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AnnouncementWebMotors announcementWebmotors)
        {
            try
            {
                _logger.LogInformation("Chamou o Put");

                _announcementWebMotorsService.Update(announcementWebmotors);
                return Ok(announcementWebmotors);
            }
            catch (ArgumentNullException e)
            {
                _logger.LogError(e.Message);
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message + " | " + e.InnerException);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromUri] int id)
        {
            try
            {
                _logger.LogInformation("Chamou o Delete");

                var _employee = _announcementWebMotorsService.GetById(id);

                if (_employee != null)
                {
                    _announcementWebMotorsService.Remove(_employee);
                }

                return Ok();
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