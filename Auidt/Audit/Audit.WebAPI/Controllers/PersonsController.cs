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
    public class PersonsController : ControllerBase
    {
        IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _personService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbypersonid")]
        public IActionResult GetById(int personId)
        {
            var result = _personService.GetById(personId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyidentificationno")]
        public IActionResult GetByIdentificationNo(string identificationNo)
        {
            var result = _personService.GetByIdentificationNo(identificationNo);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbytypeid")]
        public IActionResult GetAllByTelephoneNo(string telephoneNo)
        {
            var result = _personService.GetAllByTelephoneNo(telephoneNo);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Person person)
        {
            var result = _personService.Add(person);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Person person)
        {
            var result = _personService.Delete(person);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Person person)
        {
            var result = _personService.Update(person);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }



    }
}
