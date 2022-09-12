using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodDonationManagement.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "schoolModels",
                columns: new[] { "DonarId", "DonarAddress", "DonarCity", "DonarName" },
                values: new object[] { 1, "Davangere", "Delhi", "Shyyub" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "schoolModels",
                keyColumn: "DonarId",
                keyValue: 1);
        }
    }
}
