using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class EnumFunctie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Functie",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Functie",
                table: "Employees");
        }
    }
}
