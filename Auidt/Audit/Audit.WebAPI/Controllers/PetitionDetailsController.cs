using Audit.Business.Abstract;
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
    public class PetitionDetailsController : ControllerBase
    {
        IPetitionDetailService _petitionDetailService;

        public PetitionDetailsController(IPetitionDetailService petitionDetailService)
        {
            _petitionDetailService = petitionDetailService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _petitionDetailService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetByPetitionId(int petitionId)
        {
            var result = _petitionDetailService.GetByPetitionId(petitionId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("getbyproviderid")]
        public IActionResult GetByHealthcareProviderId(int healthcareProviderId)
        {
            var result = _petitionDetailService.GetByHealthcareProviderId(healthcareProviderId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
