using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddBatchesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OBTN",
                columns: table => new
                {
                    itemCode = table.Column<string>(type: "varchar(50)", nullable: false),
                    batchNum = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    mnfSerial = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    expDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    inDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    mnfDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    qty = table.Column<float>(type: "float", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_OBTN", x => new { x.itemCode, x.batchNum });
                    table.ForeignKey(
                        name: "FK_INV_OBTN_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OBTN_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OBTN_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OBTN_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_OBTN_createdBy",
                table: "INV_OBTN",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OBTN_objType",
                table: "INV_OBTN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OBTN_updatedBy",
                table: "INV_OBTN",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_OBTN");
        }
    }
}
