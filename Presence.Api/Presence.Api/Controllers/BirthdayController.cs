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
    public class BirthdayController : ControllerBase
    {
        private readonly IBirthdayBL _birthdayBL;
        public BirthdayController(IBirthdayBL birthday)
        {
            _birthdayBL = birthday;
        }
        // GET: api/<BirthdayController>/GetAllBirthdays
        [HttpGet]
        [Route("GetAllBirthdays")]
        public IActionResult GetAllBirthdays()
        {
            try
            {
                List<BirthdayDTO> birthdays = _birthdayBL.GetAllBirthday();
                return Ok(birthdays);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<BirthdayController>/GetBirthdayById/5
        [HttpGet]
        [Route("GetBirthdayById/{id}")]
        public IActionResult GetBirthdayById(int id)
        {
            try
            {
                BirthdayDTO birthday = _birthdayBL.GetBirthdayById(id);
                if (birthday != null)
                    return Ok(birthday);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<BirthdayController>/AddBirthday
        [HttpPost]
        [Route("AddBirthday")]
        public IActionResult AddBirthday([FromBody] BirthdayDTO birthday)
        {
            try
            {
                _birthdayBL.AddBirthday(birthday);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<BirthdayController>/UpdateBirthday/5
        [HttpPut("UpdateBirthday/{id}")]
        public IActionResult UpdateBirthday(int id, [FromBody] BirthdayDTO birthday)
        {
            try
            {
                _birthdayBL.UpdateBirthday(birthday, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<BirthdayController>/DeleteBirthday/5
        [HttpDelete("DeleteBirthday/{id}")]
        public IActionResult DeleteBirthday(int id)
        {
            try
            {
                _birthdayBL.DeleteBirthday(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
