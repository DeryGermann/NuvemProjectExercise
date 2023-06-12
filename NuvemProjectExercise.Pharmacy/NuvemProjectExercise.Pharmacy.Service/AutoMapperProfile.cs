using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy;
using NuvemProjectExercise.Pharmacy.Service.Models;

namespace NuvemProjectExercise.Pharmacy.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PharmacyModel, GetPharmacyResponseDto>();
            CreateMap<PharmacyModel, UpdatePharmacyRequestDto>();
        }
    }
}