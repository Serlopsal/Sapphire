using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddCurrencyRatesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADM_ORTT",
                columns: table => new
                {
                    rateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    curCode = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    rate = table.Column<float>(type: "float", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_ORTT", x => new { x.rateDate, x.curCode });
                    table.ForeignKey(
                        name: "FK_ADM_ORTT_ADM_OCRN_curCode",
                        column: x => x.curCode,
                        principalTable: "ADM_OCRN",
                        principalColumn: "currCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_ORTT_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_ORTT_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_ORTT_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ORTT_createdBy",
                table: "ADM_ORTT",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ORTT_curCode",
                table: "ADM_ORTT",
                column: "curCode");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ORTT_objType",
                table: "ADM_ORTT",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ORTT_updatedBy",
                table: "ADM_ORTT",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADM_ORTT");
        }
    }
}
