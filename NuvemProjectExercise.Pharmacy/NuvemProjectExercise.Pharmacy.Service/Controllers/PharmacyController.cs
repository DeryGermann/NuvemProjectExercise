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
        public async Task<ActionResult<PharmacyServiceResponse<List<GetPharmacyResponseDto>>>> Get()
        {
            return Ok(await _pharmacyService.GetAllPharmacies());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PharmacyServiceResponse<GetPharmacyResponseDto>>> GetSingle(int id)
        {
            return Ok(await _pharmacyService.GetPharmacyById(id));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PharmacyServiceResponse<GetPharmacyResponseDto>>> UpdateSingle(int id, [FromBody] UpdatePharmacyRequestDto pharmacyModel)
        {
            return Ok(await _pharmacyService.UpdatePharmacyById(id, pharmacyModel));
        }
    }
}