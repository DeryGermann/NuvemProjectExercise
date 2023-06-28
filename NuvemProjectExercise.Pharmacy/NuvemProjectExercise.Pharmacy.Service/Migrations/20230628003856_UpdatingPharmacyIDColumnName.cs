using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NuvemProjectExercise.Pharmacy.Service.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingPharmacyIDColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pharmacies",
                newName: "PharmacyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PharmacyID",
                table: "Pharmacies",
                newName: "Id");
        }
    }
}
