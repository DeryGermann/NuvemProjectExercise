namespace NuvemProjectExercise.Pharmacy.Service.Models.DatabaseCreatedModels;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
}
