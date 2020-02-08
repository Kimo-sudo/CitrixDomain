using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class ModelResha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KoffieBattleInput_KoffieBattle_MaandId",
                table: "KoffieBattleInput");

            migrationBuilder.DropIndex(
                name: "IX_KoffieBattleInput_MaandId",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "MaandId",
                table: "KoffieBattleInput");

            migrationBuilder.AddColumn<int>(
                name: "KoffieBattleId",
                table: "KoffieBattleInput",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KoffieBattleInput_KoffieBattleId",
                table: "KoffieBattleInput",
                column: "KoffieBattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_KoffieBattleInput_KoffieBattle_KoffieBattleId",
                table: "KoffieBattleInput",
                column: "KoffieBattleId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KoffieBattleInput_KoffieBattle_KoffieBattleId",
                table: "KoffieBattleInput");

            migrationBuilder.DropIndex(
                name: "IX_KoffieBattleInput_KoffieBattleId",
                table: "KoffieBattleInput");

            migrationBuilder.DropColumn(
                name: "KoffieBattleId",
                table: "KoffieBattleInput");

            migrationBuilder.AddColumn<int>(
                name: "MaandId",
                table: "KoffieBattleInput",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KoffieBattleInput_MaandId",
                table: "KoffieBattleInput",
                column: "MaandId");

            migrationBuilder.AddForeignKey(
                name: "FK_KoffieBattleInput_KoffieBattle_MaandId",
                table: "KoffieBattleInput",
                column: "MaandId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
