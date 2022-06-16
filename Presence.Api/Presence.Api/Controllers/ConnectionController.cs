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
    public class ConnectionController : ControllerBase
    {
        private readonly IConnectionBL _connectionBL;
        public ConnectionController(IConnectionBL connectionBL)
        {
            _connectionBL = connectionBL;
        }
        // GET: api/<ConnectionController>/GetAllConnections
        [HttpGet]
        [Route("GetAllConnections")]
        public IActionResult GetAllConnections()
        {
            try
            {
                List<ConnectionDTO> connections = _connectionBL.GetAllConnections();
                return Ok(connections);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<ConnectionController>/GetConnectionById/5
        [HttpGet]
        [Route("GetConnectionById/{id}")]
        public IActionResult GetConnectionById(int id)
        {
            try
            {
                ConnectionDTO connection = _connectionBL.GetConnectionById(id);
                if (connection != null)
                    return Ok(connection);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
