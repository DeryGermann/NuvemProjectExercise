namespace NuvemProjectExercise.Pharmacy.Service.Dtos.Pharmacy
{
    public class UpdatePharmacyRequestDto
    {
        public string PharmacyName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public int FilledPrescriptions { get; set; }
    }
}