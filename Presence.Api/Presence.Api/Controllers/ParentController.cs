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
    public class ParentController : ControllerBase
    {
        private readonly IParentBL _parentBL;
        public ParentController(IParentBL parentBL)
        {
            _parentBL = parentBL;
        }
        // GET: api/<ParentController>/GetAllParents
        [HttpGet]
        [Route("GetAllParents")]
        public IActionResult GetAllParents()
        {
            try
            {
                List<ParentDTO> parents = _parentBL.GetAllParents();
                return Ok(parents);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<ParentController>/GetParentById/5
        [HttpGet]
        [Route("GetParentById/{id}")]
        public IActionResult GetParentById(int id)
        {
            try
            {
                ParentDTO parent = _parentBL.GetParentById(id);
                if (parent != null)
                    return Ok(parent);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // POST api/AddParent/<ParentController>
        [HttpPost]
        [Route("AddParent")]
        public IActionResult AddParent([FromBody] ParentDTO parent)
        {
            try
            {
                _parentBL.AddParent(parent);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<ParentController>/UpdateParent/5
        [HttpPut("UpdateParent/{id}")]
        public IActionResult UpdateParent(int id, [FromBody] ParentDTO parent)
        {
            try
            {
                _parentBL.UpdateParent(parent, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<ParentController>/DeleteParent/5
        [HttpDelete("DeleteParent/{id}")]
        public IActionResult DeleteParent(int id)
        {
            try
            {
                _parentBL.DeleteParent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
