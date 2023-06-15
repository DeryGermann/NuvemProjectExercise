using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuvemProjectExercise.Pharmacy.Service.Models
{
    public class PharmacyServiceResponse<T>
    {
        public T? Data { get; set; } 
        public bool Success { get; set; } = true;
        public string Status { get; set; } = "500";
        public string Message { get; set; } = string.Empty;
    }
}