using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vezeeta.Repository.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
table: "AspNetRoles",
columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
values: new object[,]
{
        { Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() },
        { Guid.NewGuid().ToString(), "Doctor", "Doctor".ToUpper(), Guid.NewGuid().ToString() },
        { Guid.NewGuid().ToString(), "Patient", "Patient".ToUpper(), Guid.NewGuid().ToString() }
});


            migrationBuilder.InsertData(
           table: "Specializations",
           columns: new[] { "Id", "Specialization_Name" },
           values: new object[,]
           {
        { 1, "Cardiologist" },
        { 2, "Pediatrician" },
        { 3, "Dermatologist" },
        { 4, "Neurologist" },
        { 5, "Gastroenterologist" }
           });

    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
