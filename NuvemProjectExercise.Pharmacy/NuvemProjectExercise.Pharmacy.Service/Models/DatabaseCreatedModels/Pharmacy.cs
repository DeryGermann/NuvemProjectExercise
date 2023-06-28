using System.ComponentModel.DataAnnotations;

namespace NuvemProjectExercise.Pharmacy.Service.Models.DatabaseCreatedModels;

public partial class Pharmacy2
{
    [Key]
    public int PharmacyId { get; set; }

    public string PharmacyName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public int FilledPrescriptions { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual ICollection<Pharmacist> Pharmacists { get; set; } = new List<Pharmacist>();
}
