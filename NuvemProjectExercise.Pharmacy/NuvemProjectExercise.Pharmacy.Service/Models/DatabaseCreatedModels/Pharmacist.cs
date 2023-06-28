namespace NuvemProjectExercise.Pharmacy.Service.Models.DatabaseCreatedModels;

public partial class Pharmacist
{
    public int PharmacistId { get; set; }

    public int? PharmacyId { get; set; }

    public string? PharmacistName { get; set; }

    public int? Age { get; set; }

    public string? PrimaryDrugSold { get; set; }

    public DateTime? HireDate { get; set; }

    public virtual Pharmacy2? Pharmacy { get; set; }
}
