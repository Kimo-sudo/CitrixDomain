using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class GenericBattlev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputBattleData_KoffieBattle_CurrentBattleId",
                table: "InputBattleData");

            migrationBuilder.DropIndex(
                name: "IX_InputBattleData_CurrentBattleId",
                table: "InputBattleData");

            migrationBuilder.DropColumn(
                name: "CurrentBattleId",
                table: "InputBattleData");

            migrationBuilder.AddColumn<int>(
                name: "GegevensId",
                table: "InputBattleData",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InputBattleData_GegevensId",
                table: "InputBattleData",
                column: "GegevensId");

            migrationBuilder.AddForeignKey(
                name: "FK_InputBattleData_KoffieBattle_GegevensId",
                table: "InputBattleData",
                column: "GegevensId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputBattleData_KoffieBattle_GegevensId",
                table: "InputBattleData");

            migrationBuilder.DropIndex(
                name: "IX_InputBattleData_GegevensId",
                table: "InputBattleData");

            migrationBuilder.DropColumn(
                name: "GegevensId",
                table: "InputBattleData");

            migrationBuilder.AddColumn<int>(
                name: "CurrentBattleId",
                table: "InputBattleData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InputBattleData_CurrentBattleId",
                table: "InputBattleData",
                column: "CurrentBattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_InputBattleData_KoffieBattle_CurrentBattleId",
                table: "InputBattleData",
                column: "CurrentBattleId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
