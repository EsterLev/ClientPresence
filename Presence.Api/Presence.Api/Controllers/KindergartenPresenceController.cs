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
    public class KindergartenPresenceController : ControllerBase
    {
        private readonly IKindergartenPresenceBL _kindergartenPresenceBL;
        public KindergartenPresenceController(IKindergartenPresenceBL kindergartenPresenceBL)
        {
            _kindergartenPresenceBL = kindergartenPresenceBL;
        }
        // GET: api/<KindergartenPresenceController>/GetAllKindergartenPresences
        [HttpGet]
        [Route("GetAllKindergartenPresences")]
        public IActionResult GetAllKindergartenPresences()
        {
            try
            {
                List<KindergartenPresenceDTO> kindergartenPresences = _kindergartenPresenceBL.GetAllKindergartenPresences();
                return Ok(kindergartenPresences);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<KindergartenPresenceController>/GetKindergartenPresenceById/5
        [HttpGet]
        [Route("GetKindergartenPresenceById/{id}")]
        public IActionResult GetKindergartenPresenceById(int id)
        {
            try
            {
                KindergartenPresenceDTO kindergartenPresence = _kindergartenPresenceBL.GetKindergartenPresenceById(id);
                if (kindergartenPresence != null)
                    return Ok(kindergartenPresence);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // POST api/<KindergartenPresenceController>/AddKindergartenPresence
        [HttpPost]
        [Route("AddKindergartenPresence")]
        public IActionResult AddKindergartenPresence([FromBody] KindergartenPresenceDTO kindergartenPresence)
        {
            try
            {
                _kindergartenPresenceBL.AddKindergartenPresence(kindergartenPresence);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<KindergartenPresenceController>/UpdateKindergartenPresence/5
        [HttpPut("UpdateKindergartenPresence/{id}")]
        public IActionResult UpdateKindergartenPresence(int id, [FromBody] KindergartenPresenceDTO kindergartenPresence)
        {
            try
            {
                _kindergartenPresenceBL.UpdateKindergartenPresence(kindergartenPresence, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<KindergartenPresenceController>/DeleteKindergartenPresence/5
        [HttpDelete("DeleteKindergartenPresence/{id}")]
        public IActionResult DeleteKindergartenPresence(int id)
        {
            try
            {
                _kindergartenPresenceBL.DeleteKindergartenPresence(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
