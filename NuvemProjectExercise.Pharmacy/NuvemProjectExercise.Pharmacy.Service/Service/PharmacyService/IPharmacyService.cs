using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;

namespace NuvemProjectExercise.Pharmacy.Service.Service.PharmacyService
{
    public interface IPharmacyService
    {
        Task<PharmacyServiceResponse<List<PharmacyResponseDto>>> GetAllPharmacies();
        Task<PharmacyServiceResponse<PharmacyResponseDto>> GetPharmacyById(int id);
        Task<PharmacyServiceResponse<PharmacyResponseDto>> UpdatePharmacyById(int id, UpdatePharmacyRequestDto pharmacyModel);
    }
}