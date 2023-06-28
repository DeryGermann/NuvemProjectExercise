using Microsoft.EntityFrameworkCore;
using NuvemProjectExercise.Pharmacy.Service.Models.DatabaseCreatedModels;

namespace NuvemProjectExercise.Pharmacy.Service.Data;

public partial class NuvemProjectExerciseContext : DbContext
{
    public NuvemProjectExerciseContext()
    {
    }

    public NuvemProjectExerciseContext(DbContextOptions<NuvemProjectExerciseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Pharmacist> Pharmacists { get; set; }

    public virtual DbSet<Pharmacy2> Pharmacies { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=NuvemProjectExercise; User Id=sa; Password=340BasicTestProject; Trusted_Connection=false; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.DeliveryId).HasName("PK__Deliveri__626D8FEE9D56C739");

            entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.PharmacyId).HasColumnName("PharmacyID");
            entity.Property(e => e.TotalPrice).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Pharmacy).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.PharmacyId)
                .HasConstraintName("FK__Deliverie__Pharm__5165187F");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__Deliverie__Wareh__5070F446");
        });

        modelBuilder.Entity<Pharmacist>(entity =>
        {
            entity.HasKey(e => e.PharmacistId).HasName("PK__Pharmaci__5B5BDAF6714FAA92");

            entity.Property(e => e.PharmacistId).HasColumnName("PharmacistID");
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.PharmacyId).HasColumnName("PharmacyID");

            entity.HasOne(d => d.Pharmacy).WithMany(p => p.Pharmacists)
                .HasForeignKey(d => d.PharmacyId)
                .HasConstraintName("FK__Pharmacis__Pharm__4BAC3F29");
        });

        modelBuilder.Entity<Pharmacy2>(entity =>
        {
            entity.Property(e => e.PharmacyId).HasColumnName("PharmacyID");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK__Warehous__2608AFD98EC75DBE");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
