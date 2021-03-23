using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ADM_OADM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    companyAddress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    zipCode = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    webPage = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    phone1 = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true),
                    phone2 = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true),
                    mainCur = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    sysCur = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_OADM", x => x.id);
                    table.ForeignKey(
                        name: "FK_ADM_OADM_ADM_OCRY_countryId",
                        column: x => x.countryId,
                        principalTable: "ADM_OCRY",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OADM_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OADM_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OADM_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OADM_countryId",
                table: "ADM_OADM",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OADM_createdBy",
                table: "ADM_OADM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OADM_objType",
                table: "ADM_OADM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OADM_updatedBy",
                table: "ADM_OADM",
                column: "updatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ADM_OADM_companyId",
                table: "AspNetUsers",
                column: "companyId",
                principalTable: "ADM_OADM",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ADM_OADM_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ADM_OADM");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "AspNetUsers");
        }
    }
}
