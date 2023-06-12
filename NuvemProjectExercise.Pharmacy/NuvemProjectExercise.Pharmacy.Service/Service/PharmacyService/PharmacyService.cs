using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;

namespace NuvemProjectExercise.Pharmacy.Service.Service.PharmacyService
{
    public class PharmacyService : IPharmacyService
    {
        private static List<PharmacyModel> pharmacyList = new List<PharmacyModel>() {
            new PharmacyModel { Id = 1 },
            new PharmacyModel { Id = 2 },
            new PharmacyModel { Id = 3 },
            new PharmacyModel { Id = 4 },
            new PharmacyModel { Id = 5 }
        };
        public IMapper _mapper { get; }

        public PharmacyService(IMapper mapper)
        {
            _mapper = mapper;
            
        }

        public async Task<PharmacyServiceResponse<List<GetPharmacyResponseDto>>> GetAllPharmacies()
        {
            return new PharmacyServiceResponse<List<GetPharmacyResponseDto>>() {
                Data = pharmacyList.Select(p => _mapper.Map<GetPharmacyResponseDto>(p)).ToList()
            };
        }

        public async Task<PharmacyServiceResponse<GetPharmacyResponseDto>> GetPharmacyById(int id)
        {
            var pharmacy = pharmacyList.FirstOrDefault(p => p.Id == id);

            if (pharmacy is not null) {
                return new PharmacyServiceResponse<GetPharmacyResponseDto>() {
                    Data = _mapper.Map<GetPharmacyResponseDto>(pharmacy)
                };
            }

            // TODO
            // Update service response
            throw new Exception("Pharmacy not found.");
        }

        public async Task<PharmacyServiceResponse<GetPharmacyResponseDto>> UpdatePharmacyById(int id, UpdatePharmacyRequestDto pharmacyModel)
        {
            var originalPharmacy = pharmacyList.FirstOrDefault(p => p.Id == id);

            if (originalPharmacy is not null) {
                PharmacyModel newPharmacyModel = new PharmacyModel() {
                    Id = originalPharmacy.Id,
                    Name = !string.IsNullOrWhiteSpace(pharmacyModel.Name) ? pharmacyModel.Name : originalPharmacy.Name,
                    Address = !string.IsNullOrWhiteSpace(pharmacyModel.Address) ? pharmacyModel.Address : originalPharmacy.Address,
                    City = !string.IsNullOrWhiteSpace(pharmacyModel.City) ? pharmacyModel.City : originalPharmacy.City,
                    State = !string.IsNullOrWhiteSpace(pharmacyModel.State) ? pharmacyModel.State : originalPharmacy.State,
                    Zip = !string.IsNullOrWhiteSpace(pharmacyModel.Zip) ? pharmacyModel.Zip : originalPharmacy.Zip,
                    FilledPrescriptions = pharmacyModel.FilledPrescriptions >= 0 ? pharmacyModel.FilledPrescriptions : originalPharmacy.FilledPrescriptions,
                    CreatedDate = originalPharmacy.CreatedDate,
                    UpdatedDate = DateTime.Now,
                };

                return new PharmacyServiceResponse<GetPharmacyResponseDto>() {
                    Data = _mapper.Map<GetPharmacyResponseDto>(newPharmacyModel)
                };
            }

            // TODO
            // Update service response
            throw new Exception("Pharmacy not found.");
        }
    }
}