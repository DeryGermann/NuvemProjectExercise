using NuvemProjectExercise.Pharmacy.Service.Dtos.Reporting;
using NuvemProjectExercise.Pharmacy.Service.Models;

namespace NuvemProjectExercise.Pharmacy.Service.Service.ReportingService
{
    public interface IReportingService
    {
        Task<ServiceResponse<List<DeliveryDetailResponseDto>>> GetAllDeliverDetails();
    }
}