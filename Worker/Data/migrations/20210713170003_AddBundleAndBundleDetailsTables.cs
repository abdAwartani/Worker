using Microsoft.EntityFrameworkCore.Migrations;

namespace Worker.Data.migrations
{
    public partial class AddBundleAndBundleDetailsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bundles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bundles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BundleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BundleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BundleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BundleDetails_Bundles_BundleId",
                        column: x => x.BundleId,
                        principalTable: "Bundles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BundleDetails_BundleId",
                table: "BundleDetails",
                column: "BundleId");

            migrationBuilder.CreateIndex(
                name: "IX_BundleDetails_Id",
                table: "BundleDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bundles_Id",
                table: "Bundles",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BundleDetails");

            migrationBuilder.DropTable(
                name: "Bundles");
        }
    }
}
