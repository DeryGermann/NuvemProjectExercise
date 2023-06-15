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

        public async Task<PharmacyServiceResponse<List<GetPharmacyResponseDto>>> GetAllPharmacies()
        {
            var pharmacies = await _pcontext.Pharmacies.ToListAsync();

            return new PharmacyServiceResponse<List<GetPharmacyResponseDto>>() {
                Data = pharmacies.Select(p => _mapper.Map<GetPharmacyResponseDto>(p)).ToList()
            };
        }

        public async Task<PharmacyServiceResponse<GetPharmacyResponseDto>> GetPharmacyById(int id)
        {
            var pharmacies = await _pcontext.Pharmacies.ToListAsync();
            var pharmacy = pharmacies.FirstOrDefault(p => p.Id == id);

            if (pharmacy is not null) {
                return new PharmacyServiceResponse<GetPharmacyResponseDto>() {
                    Data = _mapper.Map<GetPharmacyResponseDto>(pharmacy)
                };
            }

            return new PharmacyServiceResponse<GetPharmacyResponseDto>() {
                Data = null,
                Message = $"Could not find pharmacy with Id: {id}",
                Success = false
            };
        }

        public async Task<PharmacyServiceResponse<GetPharmacyResponseDto>> UpdatePharmacyById(int id, UpdatePharmacyRequestDto pharmacyModel)
        {
            PharmacyServiceResponse<GetPharmacyResponseDto> returnResult = new PharmacyServiceResponse<GetPharmacyResponseDto>();
            
            var pharmacies = await _pcontext.Pharmacies.ToListAsync();
            var originalPharmacy = pharmacies.FirstOrDefault(p => p.Id == id);

            if (originalPharmacy is not null) {
                PharmacyModel newPharmacyModel = new PharmacyModel();

                try
                {
                    newPharmacyModel = new PharmacyModel() {
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

                    returnResult.Data = _mapper.Map<GetPharmacyResponseDto>(newPharmacyModel);
                }
                catch (Exception e)
                {
                    returnResult.Data = null;
                    returnResult.Message = e.Message;
                    returnResult.Success = false;
                }

                return returnResult;
            }

            return new PharmacyServiceResponse<GetPharmacyResponseDto>() {
                Data = null,
                Message = $"Could not find pharmacy with Id: {id}",
                Success = false
            };
        }
    }
}