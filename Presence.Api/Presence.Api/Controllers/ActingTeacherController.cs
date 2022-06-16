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
    public class ActingTeacherController : ControllerBase
    {
        private readonly IActingTeacherBL _actingTeacherBl;
        public ActingTeacherController(IActingTeacherBL actingTeacher)
        {
            _actingTeacherBl = actingTeacher;
        }
        // GET: api/<ActingTeacherController>/GetAllActingTeachers
        [HttpGet]
        [Route("GetAllActingTeachers")]
        public async Task<IActionResult> GetAllActingTeachers()
        {
            try
            {
                List<ActingTeacherDTO> actingTeachers = await _actingTeacherBl.GetAllActingTeachers();
                return Ok(actingTeachers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<ActingTeacherController>/GetActingTeacherById/5
        [HttpGet]
        [Route("GetActingTeacherById/{id}")]
        public async Task<IActionResult> GetActingTeacherById(int id)
        {
            try
            {
                ActingTeacherDTO actingTeacher = await _actingTeacherBl.GetActingTeacherById(id);
                if (actingTeacher != null)
                    return Ok(actingTeacher);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<ActingTeacherController>/AddActingTeacher
        [HttpPost]
        [Route("AddActingTeacher")]
        public async Task<IActionResult> AddActingTeacher([FromBody] ActingTeacherDTO actingTeacher)
        {
            try
            {
                await _actingTeacherBl.AddActingTeacher(actingTeacher);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<ActingTeacherController>/UpdateActingTeacher/5
        [HttpPut("UpdateActingTeacher/{id}")]
        public async Task<IActionResult> UpdateActingTeacher(int id, [FromBody] ActingTeacherDTO actingTeacher)
        {
            try
            {
                await _actingTeacherBl.UpdateActingTeacher(actingTeacher, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<ActingTeacherController>/ActingTeacher/5
        [HttpDelete("DeleteActingTeacher/{id}")]
        public async Task<IActionResult> DeleteActingTeacher(int id)
        {
            try
            {
                await _actingTeacherBl.DeleteActingTeacher(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
