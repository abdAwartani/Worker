using Microsoft.EntityFrameworkCore.Migrations;

namespace Worker.Data.migrations
{
    public partial class AddProcessNameToBundleDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProcessName",
                table: "BundleDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcessName",
                table: "BundleDetails");
        }
    }
}
