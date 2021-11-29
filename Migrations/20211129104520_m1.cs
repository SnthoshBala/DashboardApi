using Microsoft.EntityFrameworkCore.Migrations;

namespace DashboardApi.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accelerators",
                columns: table => new
                {
                    accId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100, 1"),
                    accName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accDescr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accelerators", x => x.accId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accelerators");
        }
    }
}
