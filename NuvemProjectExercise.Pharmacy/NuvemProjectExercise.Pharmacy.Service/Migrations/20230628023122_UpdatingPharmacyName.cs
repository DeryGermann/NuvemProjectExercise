using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NuvemProjectExercise.Pharmacy.Service.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingPharmacyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Pharmacies",
                newName: "PharmacyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PharmacyName",
                table: "Pharmacies",
                newName: "Name");
        }
    }
}
