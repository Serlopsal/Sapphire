using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddWarehousesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OWHS",
                columns: table => new
                {
                    whsCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    whsName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_OWHS", x => x.whsCode);
                    table.ForeignKey(
                        name: "FK_INV_OWHS_ADM_OCST_cityId",
                        column: x => x.cityId,
                        principalTable: "ADM_OCST",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWHS_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWHS_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWHS_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWHS_cityId",
                table: "INV_OWHS",
                column: "cityId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWHS_createdBy",
                table: "INV_OWHS",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWHS_objType",
                table: "INV_OWHS",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWHS_updatedBy",
                table: "INV_OWHS",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_OWHS");
        }
    }
}
