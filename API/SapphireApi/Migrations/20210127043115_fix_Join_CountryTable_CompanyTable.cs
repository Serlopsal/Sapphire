using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class fix_Join_CountryTable_CompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_COUNTRY_id",
                schema: "ADM",
                table: "COMPANY");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_countryId",
                schema: "ADM",
                table: "COMPANY",
                column: "countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_COUNTRY_countryId",
                schema: "ADM",
                table: "COMPANY",
                column: "countryId",
                principalSchema: "ADM",
                principalTable: "COUNTRY",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_COUNTRY_countryId",
                schema: "ADM",
                table: "COMPANY");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_countryId",
                schema: "ADM",
                table: "COMPANY");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_COUNTRY_id",
                schema: "ADM",
                table: "COMPANY",
                column: "id",
                principalSchema: "ADM",
                principalTable: "COUNTRY",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
