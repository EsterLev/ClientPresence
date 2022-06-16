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
    public class StudentsPresenceController : ControllerBase
    {
        private readonly IStudentsPresenceBL _studentsPresenceBL;
        public StudentsPresenceController(IStudentsPresenceBL studentsPresenceBL)
        {
            _studentsPresenceBL = studentsPresenceBL;
        }
        // GET: api/<DelaySchoolBusController>/GetAllStudentsPresences
        [HttpGet]
        [Route("GetAllStudentsPresences")]
        public IActionResult GetAllStudentsPresences()
        {
            try
            {
                List<StudentsPresenceDTO> studentsPresences = _studentsPresenceBL.GetAllStudentsPresences();
                return Ok(studentsPresences);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<DelaySchoolBusController>/GetStudentsPresenceById/5
        [HttpGet]
        [Route("GetStudentsPresenceById/{id}")]
        public IActionResult GetStudentsPresenceById(int id)
        {
            try
            {
                StudentsPresenceDTO studentsPresence = _studentsPresenceBL.GetStudentsPresenceById(id);
                if (studentsPresence != null)
                    return Ok(studentsPresence);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // POST api/<DelaySchoolBusController>/AddStudentsPresence
        [HttpPost]
        [Route("AddStudentsPresence")]
        public IActionResult AddDelaySchoolBus([FromBody] StudentsPresenceDTO studentsPresence)
        {
            try
            {
                _studentsPresenceBL.AddStudentsPresence(studentsPresence);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<DelaySchoolBusController>/UpdateStudentsPresence/5
        [HttpPut("UpdateStudentsPresence/{id}")]
        public IActionResult UpdateStudentsPresence(int id, [FromBody] StudentsPresenceDTO studentsPresence)
        {
            try
            {
                _studentsPresenceBL.UpdateStudentsPresence(studentsPresence, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<DelaySchoolBusController>/DeleteStudentsPresence/5
        [HttpDelete("DeleteStudentsPresence/{id}")]
        public IActionResult DeleteStudentsPresence(int id)
        {
            try
            {
                _studentsPresenceBL.DeleteStudentsPresence(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
