using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class GenericBattle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KoffieBattleInput_KoffieBattle_KoffieBattleId",
                table: "KoffieBattleInput");

            migrationBuilder.DropForeignKey(
                name: "FK_KoffieBattleInput_Employees_VerstuurdDoorEmployeeId",
                table: "KoffieBattleInput");

            migrationBuilder.DropIndex(
                name: "IX_KoffieBattleInput_KoffieBattleId",
                table: "KoffieBattleInput");

            migrationBuilder.DropIndex(
                name: "IX_KoffieBattleInput_VerstuurdDoorEmployeeId",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "DatumVerstuurd",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "GroteKoffie",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "KoffieBattleId",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "MediumKoffie",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "Restaurant",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "VerstuurdDoorEmployeeId",
                table: "KoffieBattleInput");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "KoffieBattleInput",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "KoffieBattleInput",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumVerstuurd",
                table: "KoffieBattle",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GroteKoffie",
                table: "KoffieBattle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MediumKoffie",
                table: "KoffieBattle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Restaurant",
                table: "KoffieBattle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VerstuurdDoorEmployeeId",
                table: "KoffieBattle",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BattleInput",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentBattleId = table.Column<int>(nullable: true),
                    FranchiseBattleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleInput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BattleInput_KoffieBattle_CurrentBattleId",
                        column: x => x.CurrentBattleId,
                        principalTable: "KoffieBattle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleInput_KoffieBattleInput_FranchiseBattleId",
                        column: x => x.FranchiseBattleId,
                        principalTable: "KoffieBattleInput",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KoffieBattle_VerstuurdDoorEmployeeId",
                table: "KoffieBattle",
                column: "VerstuurdDoorEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleInput_CurrentBattleId",
                table: "BattleInput",
                column: "CurrentBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleInput_FranchiseBattleId",
                table: "BattleInput",
                column: "FranchiseBattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_KoffieBattle_Employees_VerstuurdDoorEmployeeId",
                table: "KoffieBattle",
                column: "VerstuurdDoorEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KoffieBattle_Employees_VerstuurdDoorEmployeeId",
                table: "KoffieBattle");

            migrationBuilder.DropTable(
                name: "BattleInput");

            migrationBuilder.DropIndex(
                name: "IX_KoffieBattle_VerstuurdDoorEmployeeId",
                table: "KoffieBattle");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "DatumVerstuurd",
                table: "KoffieBattle");

            migrationBuilder.DropColumn(
                name: "GroteKoffie",
                table: "KoffieBattle");

            migrationBuilder.DropColumn(
                name: "MediumKoffie",
                table: "KoffieBattle");

            migrationBuilder.DropColumn(
                name: "Restaurant",
                table: "KoffieBattle");

            migrationBuilder.DropColumn(
                name: "VerstuurdDoorEmployeeId",
                table: "KoffieBattle");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumVerstuurd",
                table: "KoffieBattleInput",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GroteKoffie",
                table: "KoffieBattleInput",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KoffieBattleId",
                table: "KoffieBattleInput",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MediumKoffie",
                table: "KoffieBattleInput",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Restaurant",
                table: "KoffieBattleInput",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VerstuurdDoorEmployeeId",
                table: "KoffieBattleInput",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KoffieBattleInput_KoffieBattleId",
                table: "KoffieBattleInput",
                column: "KoffieBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_KoffieBattleInput_VerstuurdDoorEmployeeId",
                table: "KoffieBattleInput",
                column: "VerstuurdDoorEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_KoffieBattleInput_KoffieBattle_KoffieBattleId",
                table: "KoffieBattleInput",
                column: "KoffieBattleId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KoffieBattleInput_Employees_VerstuurdDoorEmployeeId",
                table: "KoffieBattleInput",
                column: "VerstuurdDoorEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
