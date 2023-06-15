using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [ProducesResponseType(500)]
        public async Task<ActionResult<PharmacyServiceResponse<List<PharmacyResponseDto>>>> Get()
        {
            return Ok(await _pharmacyService.GetAllPharmacies());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PharmacyServiceResponse<PharmacyResponseDto>>> GetSingle(int id)
        {
            return GetHttpStatus(await _pharmacyService.GetPharmacyById(id));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<PharmacyServiceResponse<PharmacyResponseDto>>> UpdateSingle(int id, [FromBody] UpdatePharmacyRequestDto pharmacyModel)
        {
            return GetHttpStatus(await _pharmacyService.UpdatePharmacyById(id, pharmacyModel));
        }

        private ActionResult<PharmacyServiceResponse<PharmacyResponseDto>> GetHttpStatus(PharmacyServiceResponse<PharmacyResponseDto> response)
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