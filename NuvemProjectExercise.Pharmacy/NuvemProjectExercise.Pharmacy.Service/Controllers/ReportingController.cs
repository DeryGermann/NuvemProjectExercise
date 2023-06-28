using Microsoft.AspNetCore.Mvc;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;
using NuvemProjectExercise.Pharmacy.Service.Service.ReportingService;

namespace NuvemProjectExercise.Pharmacy.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportingController : ControllerBase
    {
        private readonly IReportingService _reportingService;

        public ReportingController(IReportingService reportingService)
        {
            _reportingService = reportingService;
        }

        [HttpGet("deliveries")]
        public async Task<ActionResult<ServiceResponse<PharmacyResponseDto>>> GetAllDeliveries()
        {
            return Ok(await _reportingService.GetAllDeliverDetails());
        }
    }
}