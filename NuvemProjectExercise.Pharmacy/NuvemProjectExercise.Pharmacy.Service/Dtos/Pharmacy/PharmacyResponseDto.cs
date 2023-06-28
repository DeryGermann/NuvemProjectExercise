using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy
{
    public class PharmacyResponseDto
    {
        public int PharmacyID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public int FilledPrescriptions { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}