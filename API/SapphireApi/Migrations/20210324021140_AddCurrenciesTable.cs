using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddCurrenciesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADM_OCRN",
                columns: table => new
                {
                    currCode = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    currName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_OCRN", x => x.currCode);
                    table.ForeignKey(
                        name: "FK_ADM_OCRN_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OCRN_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OCRN_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OADM_mainCur",
                table: "ADM_OADM",
                column: "mainCur",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OADM_sysCur",
                table: "ADM_OADM",
                column: "sysCur",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OCRN_createdBy",
                table: "ADM_OCRN",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OCRN_objType",
                table: "ADM_OCRN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OCRN_updatedBy",
                table: "ADM_OCRN",
                column: "updatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ADM_OADM_ADM_OCRN_mainCur",
                table: "ADM_OADM",
                column: "mainCur",
                principalTable: "ADM_OCRN",
                principalColumn: "currCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ADM_OADM_ADM_OCRN_sysCur",
                table: "ADM_OADM",
                column: "sysCur",
                principalTable: "ADM_OCRN",
                principalColumn: "currCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ADM_OADM_ADM_OCRN_mainCur",
                table: "ADM_OADM");

            migrationBuilder.DropForeignKey(
                name: "FK_ADM_OADM_ADM_OCRN_sysCur",
                table: "ADM_OADM");

            migrationBuilder.DropTable(
                name: "ADM_OCRN");

            migrationBuilder.DropIndex(
                name: "IX_ADM_OADM_mainCur",
                table: "ADM_OADM");

            migrationBuilder.DropIndex(
                name: "IX_ADM_OADM_sysCur",
                table: "ADM_OADM");
        }
    }
}
