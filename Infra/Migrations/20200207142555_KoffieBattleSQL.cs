using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class KoffieBattleSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KoffieBattleData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumVerstuurd = table.Column<DateTime>(nullable: false),
                    VerstuurdDoorEmployeeId = table.Column<int>(nullable: true),
                    GroteKoffie = table.Column<int>(nullable: false),
                    MediumKoffie = table.Column<int>(nullable: false),
                    Restaurant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoffieBattleData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KoffieBattleData_Employees_VerstuurdDoorEmployeeId",
                        column: x => x.VerstuurdDoorEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KoffieBattleData_VerstuurdDoorEmployeeId",
                table: "KoffieBattleData",
                column: "VerstuurdDoorEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KoffieBattleData");
        }
    }
}
