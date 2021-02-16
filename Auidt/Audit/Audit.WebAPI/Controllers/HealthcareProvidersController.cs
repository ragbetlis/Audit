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
    public class HealthcareProvidersController : ControllerBase
    {
        IHealthcareProviderService _healthcareProviderService;

        public HealthcareProvidersController(IHealthcareProviderService healthcareProviderService)
        {
            _healthcareProviderService = healthcareProviderService;
        }
        //IResult Add(HealthcareProvider healthcareProvider);
        //IResult Update(HealthcareProvider healthcareProvider);
        //IResult Delete(HealthcareProvider healthcareProvider);
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _healthcareProviderService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyproviderid")]
        public IActionResult GetById(int healthcareProviderId)
        {
            var result = _healthcareProviderService.GetById(healthcareProviderId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyprovidername")]
        public IActionResult GetByName(string healthcareProviderName)
        {
            var result = _healthcareProviderService.GetByName(healthcareProviderName);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbytypeid")]
        public IActionResult GetAllByType(int typeId)
        {
            var result = _healthcareProviderService.GetAllByType(typeId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(HealthcareProvider healthcareProvider)
        {
            var result = _healthcareProviderService.Add(healthcareProvider);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(HealthcareProvider healthcareProvider)
        {
            var result = _healthcareProviderService.Delete(healthcareProvider);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(HealthcareProvider healthcareProvider)
        {
            var result = _healthcareProviderService.Update(healthcareProvider);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
