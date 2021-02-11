using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OADM",
                schema: "ADM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    companyAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    webPage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phone1 = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    phone2 = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    mainCur = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    sysCur = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => x.id);
                    table.ForeignKey(
                        name: "FK_COMPANY_COUNTRY_id",
                        column: x => x.id,
                        principalSchema: "ADM",
                        principalTable: "OCRY",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OADM",
                schema: "ADM");
        }
    }
}
