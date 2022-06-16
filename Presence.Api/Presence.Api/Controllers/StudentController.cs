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
    public class StudentController : ControllerBase
    {
        private readonly IStudentBL _studentBL;
        public StudentController(IStudentBL studentBL)
        {
            _studentBL = studentBL;
        }
        // GET: api/<StudentController>/GetAllStudents
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                List<StudentDTO> students = _studentBL.GetAllStudents();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<StudentController>/GetStudentById/5
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                StudentDTO student = _studentBL.GetStudentById(id);
                if (student != null)
                    return Ok(student);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // POST api/<StudentController>/AddStudent
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent([FromBody] StudentDTO student)
        {
            try
            {
                _studentBL.AddStudent(student);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<StudentController>/UpdateStudent/5
        [HttpPut("UpdateStudent/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentDTO student)
        {
            try
            {
                _studentBL.UpdateStudent(student, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<StudentController>/DeleteStudent/5
        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                _studentBL.DeleteStudent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
