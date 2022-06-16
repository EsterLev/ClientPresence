using Microsoft.AspNetCore.Mvc;
using Presence.BL.Classes;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presence.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolBusController : ControllerBase
    {
        private readonly ISchoolBusBL _schoolBusBL;
        public SchoolBusController(ISchoolBusBL schoolBus)
        {
            _schoolBusBL = schoolBus;
        }
        // GET: api/<SchoolBusController>/GetAllSchoolBuses
        [HttpGet]
        [Route("GetAllSchoolBuses")]
        public IActionResult GetAllSchoolBuses()
        {
            try
            {
                List<SchoolBusDTO> schoolBuses = _schoolBusBL.GetAllSchoolBuses();
                return Ok(schoolBuses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<SchoolBusController>/GetSchooolBusById/5
        [HttpGet]
        [Route("GetSchooolBusById/{id}")]
        public IActionResult GetSchooolBusById(int id)
        {
            try
            {
                SchoolBusDTO schoolBus = _schoolBusBL.GetSchoolBusById(id);
                if (schoolBus != null)
                    return Ok(schoolBus);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<SchoolBusController>/AddSchoolBus
        [HttpPost]
        [Route("AddSchoolBus")]
        public IActionResult AddSchoolBus([FromBody] SchoolBusDTO schoolBus)
        {
            try
            {
                _schoolBusBL.AddSchoolBus(schoolBus);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<SchoolBusController>/UpdateSchoolBus/5
        [HttpPut("UpdateSchoolBus/{id}")]
        public IActionResult UpdateSchoolBus(int id, [FromBody] SchoolBusDTO schoolBus)
        {
            try
            {
                _schoolBusBL.UpdateSchoolBus(schoolBus, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<SchoolBusController>/DeleteSchoolBus/5
        [HttpDelete("DeleteSchoolBus/{id}")]
        public IActionResult DeleteSchoolBus(int id)
        {
            try
            {
                _schoolBusBL.DeleteParent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
