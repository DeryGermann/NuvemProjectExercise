using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy
{
    public class UpdatePharmacyRequestDto
    {
        public string Name { get; set; } = "Missing Pharamacy Name";
        public string Address { get; set; } = "Missing Pharamacy Address";
        public string City { get; set; } = "Missing Pharamacy City";
        public string State { get; set; } = "Missing Pharamacy State";
        public string Zip { get; set; } = "Missing Pharamacy Zip";
        public int FilledPrescriptions { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}