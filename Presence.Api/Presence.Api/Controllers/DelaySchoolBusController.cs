using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presence.BL.Classes;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presence.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelaySchoolBusController : ControllerBase
    {
        private readonly IDelaySchoolBusBL _delaySchoolBusBL;
        public DelaySchoolBusController(IDelaySchoolBusBL delaySchoolBusBL)
        {
            _delaySchoolBusBL = delaySchoolBusBL;
        }
        // GET: api/<DelaySchoolBusController>/GetAllDelaySchoolBuses
        [HttpGet]
        [Route("GetAllDelaySchoolBuses")]
        public IActionResult GetAllDelaySchoolBuses()
        {
            try
            {
                List<DelaySchoolBusDTO> delaySchoolBuses = _delaySchoolBusBL.GetAllDelaySchoolBuses();
                return Ok(delaySchoolBuses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<DelaySchoolBusController>/GetDelaySchoolBusById/5
        [HttpGet]
        [Route("GetDelaySchoolBusById/{id}")]
        public IActionResult GetDelaySchoolBusById(int id)
        {
            try
            {
                DelaySchoolBusDTO delaySchoolBus = _delaySchoolBusBL.GetDelaySchoolBusById(id);
                if (delaySchoolBus != null)
                    return Ok(delaySchoolBus);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // POST api/<DelaySchoolBusController>/AddDelaySchoolBus
        [HttpPost]
        [Route("AddDelaySchoolBus")]
        public IActionResult AddDelaySchoolBus([FromBody] DelaySchoolBusDTO delaySchoolBus)
        {
            try
            {
                _delaySchoolBusBL.AddDelaySchoolBus(delaySchoolBus);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<DelaySchoolBusController>/UpdateDelaySchoolBus/5
        [HttpPut("UpdateDelaySchoolBus/{id}")]
        public IActionResult UpdateDelaySchoolBus(int id, [FromBody] DelaySchoolBusDTO delaySchoolBus)
        {
            try
            {
                _delaySchoolBusBL.UpdateDelaySchoolBus(delaySchoolBus, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<DelaySchoolBusController>/DeleteDelaySchoolBus/5
        [HttpDelete("DeleteDelaySchoolBus/{id}")]
        public IActionResult DeleteDelaySchoolBus(int id)
        {
            try
            {
                _delaySchoolBusBL.DeleteDelaySchoolBus(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
