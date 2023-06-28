using Microsoft.AspNetCore.Mvc;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;
using NuvemProjectExercise.Pharmacy.Service.Service.PharmacyService;

namespace NuvemProjectExercise.Pharmacy.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PharmacyController : ControllerBase
    {
        private readonly IPharmacyService _pharmacyService;

        public PharmacyController(IPharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(200)]
        [ProducesResponseType(200)]
        public async Task<ActionResult<ServiceResponse<List<PharmacyResponseDto>>>> Get()
        {
            return Ok(await _pharmacyService.GetAllPharmacies());
        }

        [HttpGet("{pharmacyID}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ServiceResponse<PharmacyResponseDto>>> GetSingle(int pharmacyID)
        {
            return GetHttpStatus(await _pharmacyService.GetPharmacyById(pharmacyID));
        }

        [HttpPut("{pharmacyID}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ServiceResponse<PharmacyResponseDto>>> UpdateSingle(int pharmacyID, [FromBody] UpdatePharmacyRequestDto pharmacyModel)
        {
            return GetHttpStatus(await _pharmacyService.UpdatePharmacyById(pharmacyID, pharmacyModel));
        }

        private ActionResult<ServiceResponse<PharmacyResponseDto>> GetHttpStatus(ServiceResponse<PharmacyResponseDto> response)
        {
            switch (response.Status)
            {
                case "200":
                    return Ok(response);
                case "404":
                    return NotFound(response);
                default:
                    return BadRequest(response);
            }
        }
    }
}