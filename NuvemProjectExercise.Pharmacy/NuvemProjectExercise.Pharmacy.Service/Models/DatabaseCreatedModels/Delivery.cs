namespace NuvemProjectExercise.Pharmacy.Service.Models.DatabaseCreatedModels;

public partial class Delivery
{
    public int DeliveryId { get; set; }

    public int? WarehouseId { get; set; }

    public int? PharmacyId { get; set; }

    public string? DrugName { get; set; }

    public int? UnitCount { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public virtual Pharmacy2? Pharmacy { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
