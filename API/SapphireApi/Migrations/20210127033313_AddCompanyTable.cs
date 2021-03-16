using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OADM", x => x.id);
                    table.ForeignKey(
                        name: "FK_OADM_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OADM_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OADM_OCRY_countryId",
                        column: x => x.countryId,
                        principalSchema: "ADM",
                        principalTable: "OCRY",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OADM_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_countryId",
                schema: "ADM",
                table: "OADM",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_createdBy",
                schema: "ADM",
                table: "OADM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_objType",
                schema: "ADM",
                table: "OADM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_updatedBy",
                schema: "ADM",
                table: "OADM",
                column: "updatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_OADM_companyId",
                table: "AspNetUsers",
                column: "companyId",
                principalSchema: "ADM",
                principalTable: "OADM",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_OADM_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OADM",
                schema: "ADM");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "AspNetUsers");
        }
    }
}
