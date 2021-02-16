using Audit.Business.Abstract;
using Audit.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetitionsController : ControllerBase
    {
        IPetitionService _petitionService;
        public PetitionsController(IPetitionService petitionService)
        {
            _petitionService = petitionService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _petitionService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbypetitionid")]
        public IActionResult GetById(int petitionId)
        {
            var result = _petitionService.GetById(petitionId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbypetitionerid")]
        public IActionResult GetByPetitionerId(int petitionerid)
        {
            var result = _petitionService.GetByPetitionerId(petitionerid);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbytypeid")]
        public IActionResult PetitionCase(bool petitionCase)
        {
            var result = _petitionService.PetitionCase(petitionCase);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Petition petition)
        {
            var result = _petitionService.Add(petition);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Petition petition)
        {
            var result = _petitionService.Delete(petition);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Petition petition)
        {
            var result = _petitionService.Update(petition);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
