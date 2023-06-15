using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;
using NuvemProjectExercise.Pharmacy.Service.Data;
using Microsoft.EntityFrameworkCore;

namespace NuvemProjectExercise.Pharmacy.Service.Service.PharmacyService
{
    public class PharmacyService : IPharmacyService
    {
        public readonly IMapper _mapper;
        public readonly PharmacyContext _pcontext;

        public PharmacyService(IMapper mapper, PharmacyContext pcontext)
        {
            _mapper = mapper;
            _pcontext = pcontext;
        }

        public async Task<PharmacyServiceResponse<List<PharmacyResponseDto>>> GetAllPharmacies()
        {
            try {
                var pharmacies = await _pcontext.Pharmacies.ToListAsync();

                return new PharmacyServiceResponse<List<PharmacyResponseDto>>() {
                    Data = pharmacies.Select(p => _mapper.Map<PharmacyResponseDto>(p)).ToList(),
                    Status = "200"
                };
            }
            catch
            {
                return new PharmacyServiceResponse<List<PharmacyResponseDto>>() {
                    Data = null,
                    Message = "An unknown error has occured. Please contact support."
                };
            }
        }

        public async Task<PharmacyServiceResponse<PharmacyResponseDto>> GetPharmacyById(int id)
        {
            var pharmacies = await _pcontext.Pharmacies.ToListAsync();
            var pharmacy = pharmacies.FirstOrDefault(p => p.Id == id);

            if (pharmacy is not null) {
                return new PharmacyServiceResponse<PharmacyResponseDto>() {
                    Data = _mapper.Map<PharmacyResponseDto>(pharmacy),
                    Status = "200"
                };
            }

            return new PharmacyServiceResponse<PharmacyResponseDto>() {
                Data = null,
                Message = $"Could not find pharmacy with Id: {id}",
                Success = false,
                Status = "404"
            };
        }

        public async Task<PharmacyServiceResponse<PharmacyResponseDto>> UpdatePharmacyById(int id, UpdatePharmacyRequestDto pharmacyModel)
        {
            PharmacyServiceResponse<PharmacyResponseDto> returnResult = new PharmacyServiceResponse<PharmacyResponseDto>();
            
            var pharmacies = await _pcontext.Pharmacies.ToListAsync();
            var originalPharmacy = pharmacies.FirstOrDefault(p => p.Id == id);

            if (originalPharmacy is not null) {
                try
                {
                    originalPharmacy.Name = !string.IsNullOrWhiteSpace(pharmacyModel.Name) ? pharmacyModel.Name : originalPharmacy.Name;
                    originalPharmacy.Address = !string.IsNullOrWhiteSpace(pharmacyModel.Address) ? pharmacyModel.Address : originalPharmacy.Address;
                    originalPharmacy.City = !string.IsNullOrWhiteSpace(pharmacyModel.City) ? pharmacyModel.City : originalPharmacy.City;
                    originalPharmacy.State = !string.IsNullOrWhiteSpace(pharmacyModel.State) ? pharmacyModel.State : originalPharmacy.State;
                    originalPharmacy.Zip = !string.IsNullOrWhiteSpace(pharmacyModel.Zip) ? pharmacyModel.Zip : originalPharmacy.Zip;
                    originalPharmacy.FilledPrescriptions = pharmacyModel.FilledPrescriptions >= 0 ? pharmacyModel.FilledPrescriptions : originalPharmacy.FilledPrescriptions;
                    originalPharmacy.UpdatedDate = DateTime.Now;

                    returnResult.Data = _mapper.Map<PharmacyResponseDto>(originalPharmacy);
                    returnResult.Status = "200";

                    await _pcontext.SaveChangesAsync();
                }
                catch
                {
                    returnResult.Data = null;
                    returnResult.Message = "An unknown error has occured. Please contact support.";
                    returnResult.Success = false;
                }

                return returnResult;
            }

            return new PharmacyServiceResponse<PharmacyResponseDto>() {
                Data = null,
                Message = $"Could not find pharmacy with Id: {id}",
                Success = false,
                Status = "404"
            };
        }
    }
}