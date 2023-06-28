using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;

namespace NuvemProjectExercise.Pharmacy.Service.Service.PharmacyService
{
    public interface IPharmacyService
    {
        Task<ServiceResponse<List<PharmacyResponseDto>>> GetAllPharmacies();
        Task<ServiceResponse<PharmacyResponseDto>> GetPharmacyById(int pharmacyID);
        Task<ServiceResponse<PharmacyResponseDto>> UpdatePharmacyById(int pharmacyID, UpdatePharmacyRequestDto pharmacyModel);
    }
}