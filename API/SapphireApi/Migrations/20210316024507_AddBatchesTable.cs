using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddBatchesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OBTN",
                schema: "INV",
                columns: table => new
                {
                    itemCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    batchNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mnfSerial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    expDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    inDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mnfDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qty = table.Column<float>(type: "real", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OBTN", x => new { x.itemCode, x.batchNum });
                    table.ForeignKey(
                        name: "FK_OBTN_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OBTN_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OBTN_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OBTN_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OBTN_createdBy",
                schema: "INV",
                table: "OBTN",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OBTN_objType",
                schema: "INV",
                table: "OBTN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OBTN_updatedBy",
                schema: "INV",
                table: "OBTN",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OBTN",
                schema: "INV");
        }
    }
}
