using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddWhsFkToIOTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "warehouseid",
                schema: "INV",
                table: "OIGN",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "whsCode",
                schema: "INV",
                table: "OIGN",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "warehouseid",
                schema: "INV",
                table: "OIGE",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "whsCode",
                schema: "INV",
                table: "OIGE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_warehouseid",
                schema: "INV",
                table: "OIGN",
                column: "warehouseid");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_warehouseid",
                schema: "INV",
                table: "OIGE",
                column: "warehouseid");

            migrationBuilder.AddForeignKey(
                name: "FK_OIGE_OWHS_warehouseid",
                schema: "INV",
                table: "OIGE",
                column: "warehouseid",
                principalSchema: "INV",
                principalTable: "OWHS",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OIGN_OWHS_warehouseid",
                schema: "INV",
                table: "OIGN",
                column: "warehouseid",
                principalSchema: "INV",
                principalTable: "OWHS",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OIGE_OWHS_warehouseid",
                schema: "INV",
                table: "OIGE");

            migrationBuilder.DropForeignKey(
                name: "FK_OIGN_OWHS_warehouseid",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropIndex(
                name: "IX_OIGN_warehouseid",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropIndex(
                name: "IX_OIGE_warehouseid",
                schema: "INV",
                table: "OIGE");

            migrationBuilder.DropColumn(
                name: "warehouseid",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropColumn(
                name: "whsCode",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropColumn(
                name: "warehouseid",
                schema: "INV",
                table: "OIGE");

            migrationBuilder.DropColumn(
                name: "whsCode",
                schema: "INV",
                table: "OIGE");
        }
    }
}
