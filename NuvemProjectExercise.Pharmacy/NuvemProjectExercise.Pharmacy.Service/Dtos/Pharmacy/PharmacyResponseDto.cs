namespace NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy
{
    public class PharmacyResponseDto
    {
        public int PharmacyID { get; set; }
        public string PharmacyName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public int FilledPrescriptions { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}