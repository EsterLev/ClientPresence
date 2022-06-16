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
    public class ReminderController : ControllerBase
    {
        private readonly IReminderBL _reminderBL;
        public ReminderController(IReminderBL reminder)
        {
            _reminderBL = reminder;
        }
        // GET: api/<ReminderController>/GetAllReminders
        [HttpGet]
        [Route("GetAllReminders")]
        public IActionResult GetAllReminders()
        {
            try
            {
                List<ReminderDTO> reminders = _reminderBL.GetAllReminders();
                return Ok(reminders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<ReminderController>/GetReminderById/5
        [HttpGet]
        [Route("GetReminderById/{id}")]
        public IActionResult GetReminderById(int id)
        {
            try
            {
                ReminderDTO reminder = _reminderBL.GetReminderById(id);
                if (reminder != null)
                    return Ok(reminder);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<ReminderController>/AddReminder
        [HttpPost]
        [Route("AddReminder")]
        public IActionResult AddReminder([FromBody] ReminderDTO reminder)
        {
            try
            {
                _reminderBL.AddReminder(reminder);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<ReminderController>/UpdateReminder/5
        [HttpPut("UpdateReminder/{id}")]
        public IActionResult UpdateReminder(int id, [FromBody] ReminderDTO reminder)
        {
            try
            {
                _reminderBL.UpdateReminder(reminder, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<ReminderController>/DeleteReminder/5
        [HttpDelete("DeleteReminder/{id}")]
        public IActionResult DeleteReminder(int id)
        {
            try
            {
                _reminderBL.DeleteReminder(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
