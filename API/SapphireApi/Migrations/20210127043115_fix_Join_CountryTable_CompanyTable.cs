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
                table: "OADM");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_countryId",
                schema: "ADM",
                table: "OADM",
                column: "countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_COUNTRY_countryId",
                schema: "ADM",
                table: "OADM",
                column: "countryId",
                principalSchema: "ADM",
                principalTable: "OCRY",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_COUNTRY_countryId",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_countryId",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_COUNTRY_id",
                schema: "ADM",
                table: "OADM",
                column: "id",
                principalSchema: "ADM",
                principalTable: "OCRY",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
