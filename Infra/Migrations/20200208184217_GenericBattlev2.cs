using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class GenericBattlev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleInput_KoffieBattle_CurrentBattleId",
                table: "BattleInput");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleInput_KoffieBattleInput_FranchiseBattleId",
                table: "BattleInput");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KoffieBattleInput",
                table: "KoffieBattleInput");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleInput",
                table: "BattleInput");

            migrationBuilder.RenameTable(
                name: "KoffieBattleInput",
                newName: "FranchiseBattle");

            migrationBuilder.RenameTable(
                name: "BattleInput",
                newName: "InputBattleData");

            migrationBuilder.RenameIndex(
                name: "IX_BattleInput_FranchiseBattleId",
                table: "InputBattleData",
                newName: "IX_InputBattleData_FranchiseBattleId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleInput_CurrentBattleId",
                table: "InputBattleData",
                newName: "IX_InputBattleData_CurrentBattleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FranchiseBattle",
                table: "FranchiseBattle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InputBattleData",
                table: "InputBattleData",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InputBattleData_KoffieBattle_CurrentBattleId",
                table: "InputBattleData",
                column: "CurrentBattleId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InputBattleData_FranchiseBattle_FranchiseBattleId",
                table: "InputBattleData",
                column: "FranchiseBattleId",
                principalTable: "FranchiseBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputBattleData_KoffieBattle_CurrentBattleId",
                table: "InputBattleData");

            migrationBuilder.DropForeignKey(
                name: "FK_InputBattleData_FranchiseBattle_FranchiseBattleId",
                table: "InputBattleData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InputBattleData",
                table: "InputBattleData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FranchiseBattle",
                table: "FranchiseBattle");

            migrationBuilder.RenameTable(
                name: "InputBattleData",
                newName: "BattleInput");

            migrationBuilder.RenameTable(
                name: "FranchiseBattle",
                newName: "KoffieBattleInput");

            migrationBuilder.RenameIndex(
                name: "IX_InputBattleData_FranchiseBattleId",
                table: "BattleInput",
                newName: "IX_BattleInput_FranchiseBattleId");

            migrationBuilder.RenameIndex(
                name: "IX_InputBattleData_CurrentBattleId",
                table: "BattleInput",
                newName: "IX_BattleInput_CurrentBattleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleInput",
                table: "BattleInput",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KoffieBattleInput",
                table: "KoffieBattleInput",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleInput_KoffieBattle_CurrentBattleId",
                table: "BattleInput",
                column: "CurrentBattleId",
                principalTable: "KoffieBattle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleInput_KoffieBattleInput_FranchiseBattleId",
                table: "BattleInput",
                column: "FranchiseBattleId",
                principalTable: "KoffieBattleInput",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
