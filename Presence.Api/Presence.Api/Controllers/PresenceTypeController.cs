using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presence.BL.Classes;
using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presence.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresenceTypeController : ControllerBase
    {
        private readonly IPresenceTypeBL _presenceTypeBL;
        public PresenceTypeController(IPresenceTypeBL presenceTypeBL)
        {
            _presenceTypeBL = presenceTypeBL;
        }
        // GET: api/<PresenceTypeController>/GetAllPresenceTypes
        [HttpGet]
        [Route("GetAllPresenceTypes")]
        public IActionResult GetAllPresenceTypes()
        {
            try
            {
                List<PresenceTypeDTO> presnceTypes = _presenceTypeBL.GetAllPresenceTypes();
                return Ok(presnceTypes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<PresenceTypeController>/GetPresenceTypeById/5
        [HttpGet]
        [Route("GetPresenceTypeById/{id}")]
        public IActionResult GetPresenceTypeById(int id)
        {
            try
            {
                PresenceTypeDTO presenceType = _presenceTypeBL.GetPresenceTypeById(id);
                if (presenceType != null)
                    return Ok(presenceType);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
