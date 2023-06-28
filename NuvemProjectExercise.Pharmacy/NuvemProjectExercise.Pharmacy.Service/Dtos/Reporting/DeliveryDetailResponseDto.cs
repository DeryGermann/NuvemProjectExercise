namespace NuvemProjectExercise.Pharmacy.Service.Dtos.Reporting
{
    public class DeliveryDetailResponseDto
    {
        public string WarehouseFrom { get; set; } = "Missing WarehouseFrom name";
        public string PharmacyTo { get; set; } = "Missing PharmacyTo name";

        // Delivery Model
        public string? DrugName { get; set; }

        public int? UnitCount { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        public DateTime? DeliveryDate { get; set; }
    }
}