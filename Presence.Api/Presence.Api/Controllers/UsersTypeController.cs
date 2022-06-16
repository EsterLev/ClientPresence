using Microsoft.AspNetCore.Mvc;
using Presence.BL;
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
    public class UsersTypeController : ControllerBase
    {
        private readonly IUsersTypeBL _usersTypeBL;
        public UsersTypeController(IUsersTypeBL usersTypeBL)
        {
            _usersTypeBL = usersTypeBL;
        }
        // GET: api/<UsersTypeController>/GetAllUsersTypes
        [HttpGet]
        [Route("GetAllUsersTypes")]
        public IActionResult GetAllUsersTypes()
        {
            try
            {
                List<UsersTypeDTO> usersTypes = _usersTypeBL.GetAllUsersTypes();
                return Ok(usersTypes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<UsersTypeController>/GetUsersTypeById/5
        [HttpGet]
        [Route("GetUsersTypeById/{id}")]
        public IActionResult GetUsersTypeById(int id)
        {
            try
            {
                UsersTypeDTO usersType = _usersTypeBL.GetUsersTypeById(id);
                if (usersType != null)
                    return Ok(usersType);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
