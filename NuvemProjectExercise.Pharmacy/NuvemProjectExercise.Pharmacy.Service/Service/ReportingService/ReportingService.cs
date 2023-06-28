using AutoMapper;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;
using NuvemProjectExercise.Pharmacy.Service.Data;
using Microsoft.EntityFrameworkCore;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Reporting;

namespace NuvemProjectExercise.Pharmacy.Service.Service.ReportingService
{
    public class ReportingService : IReportingService
    {
        public readonly NuvemProjectExerciseContext _rcontext;

        public ReportingService(NuvemProjectExerciseContext rcontext)
        {
            _rcontext = rcontext;
        }

        public async Task<ServiceResponse<List<DeliveryDetailResponseDto>>> GetAllDeliverDetails()
        {
            try {
                var deliveryDetails = await (
                    from d in _rcontext.Deliveries
                    join p in _rcontext.Pharmacies on d.PharmacyId equals p.PharmacyId
                    join w in _rcontext.Warehouses on d.WarehouseId equals w.WarehouseId
                    select new DeliveryDetailResponseDto {
                        WarehouseFrom = w.WarehouseName,
                        PharmacyTo = p.PharmacyName,
                        DrugName = d.DrugName,
                        UnitCount = d.UnitCount,
                        UnitPrice = d.UnitPrice,
                        TotalPrice = d.TotalPrice,
                        DeliveryDate = d.DeliveryDate
                    }).ToListAsync();

                return new ServiceResponse<List<DeliveryDetailResponseDto>>() {
                    Data = deliveryDetails,
                    Status = "200"
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<List<DeliveryDetailResponseDto>>() {
                    Data = null,
                    Message = "An unknown error has occured. Please contact support."
                };
            }
        }
    }
}