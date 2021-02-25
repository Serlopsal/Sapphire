using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddItemDispatchBatchDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "openQty",
                schema: "INV",
                table: "WTR1",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "openQty",
                schema: "INV",
                table: "WTQ1",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "openQty",
                schema: "INV",
                table: "IGN1",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "openQty",
                schema: "INV",
                table: "IGE1",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "IGE2",
                schema: "INV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    batchNum = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    itemCode = table.Column<int>(type: "int", nullable: false),
                    masterId = table.Column<int>(type: "int", nullable: false),
                    masterLine = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<float>(type: "real", nullable: false),
                    openQty = table.Column<float>(type: "real", nullable: false),
                    isClosed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IGE2", x => x.id);
                    table.ForeignKey(
                        name: "FK_IGE2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE2_IGE1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalSchema: "INV",
                        principalTable: "IGE1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE2_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalSchema: "INV",
                        principalTable: "OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE2_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE2_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IGE2_createdBy",
                schema: "INV",
                table: "IGE2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_IGE2_itemCode_batchNum",
                schema: "INV",
                table: "IGE2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_IGE2_masterId_masterLine",
                schema: "INV",
                table: "IGE2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_IGE2_objType",
                schema: "INV",
                table: "IGE2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_IGE2_updatedBy",
                schema: "INV",
                table: "IGE2",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IGE2",
                schema: "INV");

            migrationBuilder.DropColumn(
                name: "openQty",
                schema: "INV",
                table: "WTR1");

            migrationBuilder.DropColumn(
                name: "openQty",
                schema: "INV",
                table: "WTQ1");

            migrationBuilder.DropColumn(
                name: "openQty",
                schema: "INV",
                table: "IGN1");

            migrationBuilder.DropColumn(
                name: "openQty",
                schema: "INV",
                table: "IGE1");
        }
    }
}
