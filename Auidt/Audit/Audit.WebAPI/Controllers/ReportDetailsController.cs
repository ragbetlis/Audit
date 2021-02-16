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
    public class ReportDetailsController : ControllerBase
    {
        IReportDetailService _reportDetailService;

        public ReportDetailsController(IReportDetailService reportDetailService)
        {
            _reportDetailService = reportDetailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _reportDetailService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyreportid")]
        public IActionResult GetByReportId(int reportId)
        {
            var result = _reportDetailService.GetByReportId(reportId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyreportno")]
        public IActionResult GetByInspectorId(int inspectorId)
        {
            var result = _reportDetailService.GetByInspectorId(inspectorId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbytypeid")]
        public IActionResult GetByHealthcareProviderId(int healthcareProviderId)
        {
            var result = _reportDetailService.GetByHealthcareProviderId(healthcareProviderId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ReportDetail reportDetail)
        {
            var result = _reportDetailService.Add(reportDetail);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ReportDetail reportDetail)
        {
            var result = _reportDetailService.Delete(reportDetail);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ReportDetail reportDetail)
        {
            var result = _reportDetailService.Update(reportDetail);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
