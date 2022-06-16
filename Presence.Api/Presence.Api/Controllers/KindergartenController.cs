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
    public class KindergartenController : ControllerBase
    {
           private readonly IKindergartenBL _kindergartenBL;
        public KindergartenController(IKindergartenBL kindergarten)
        {
            _kindergartenBL = kindergarten;
        }
        // GET: api/<KindergartenController>/GetAllKinderGartens
        [HttpGet]
        [Route("GetAllKindergartens")]
        public IActionResult GetAllKindergartens()
        {
            try
            {
                List<KindergartenDTO> kindergartens = _kindergartenBL.GetAllKindergartens();
                return Ok(kindergartens);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<KindergartenController>/GetKindergartenById/5
        [HttpGet]
        [Route("GetKindergartenById/{id}")]
        public IActionResult GetKindergartenById(int id)
        {
            try
            {
                KindergartenDTO kindergarten = _kindergartenBL.GetKindergartenById(id);
                if (kindergarten != null)
                    return Ok(kindergarten);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<KindergartenController>/AddKindergarten
        [HttpPost]
        [Route("AddKindergarten")]
        public IActionResult AddKindergarten([FromBody] KindergartenDTO kindergarten)
        {
            try
            {
                _kindergartenBL.AddKindergarten(kindergarten);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<KindergartenController>/UpdateKindergarten/5
        [HttpPut("UpdateKindergarten/{id}")]
        public IActionResult UpdateKindergarten(int id, [FromBody] KindergartenDTO kindergarten)
        {
            try
            {
                _kindergartenBL.UpdateKindergarten(kindergarten, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<KindergartenController>/DeleteKindergarten/5
        [HttpDelete("DeleteKindergarten/{id}")]
        public IActionResult DeleteKindergarten(int id)
        {
            try
            {
                _kindergartenBL.DeleteKindergarten(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
