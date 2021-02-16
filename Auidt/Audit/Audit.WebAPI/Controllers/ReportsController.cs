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
    public class ReportsController : ControllerBase
    {
        IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _reportService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyreportid")]
        public IActionResult GetById(int reportId)
        {
            var result = _reportService.GetById(reportId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyreportno")]
        public IActionResult GetByReportNumber(string reportNumber)
        {
            var result = _reportService.GetByReportNumber(reportNumber);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbytypeid")]
        public IActionResult GetReportByDate(DateTime reportDate)
        {
            var result = _reportService.GetReportByDate(reportDate);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Report report)
        {
            var result = _reportService.Add(report);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Report report)
        {
            var result = _reportService.Delete(report);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Report report)
        {
            var result = _reportService.Update(report);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
