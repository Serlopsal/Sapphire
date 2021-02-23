using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddItemsDispatchesAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OIGE",
                schema: "INV",
                columns: table => new
                {
                    docId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    docDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isCanceled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    isPrinted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    isClosed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    docNum = table.Column<int>(type: "int", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    serieId = table.Column<int>(type: "int", nullable: false),
                    komId = table.Column<int>(type: "int", nullable: false),
                    whsCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OIGE", x => x.docId);
                    table.ForeignKey(
                        name: "FK_OIGE_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGE_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGE_OKOM_komId",
                        column: x => x.komId,
                        principalSchema: "INV",
                        principalTable: "OKOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGE_ONNM_serieId",
                        column: x => x.serieId,
                        principalSchema: "ADM",
                        principalTable: "ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGE_OWHS_whsCode",
                        column: x => x.whsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IGE1",
                schema: "INV",
                columns: table => new
                {
                    lineNum = table.Column<int>(type: "int", nullable: false),
                    docId = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    docDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isClosed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    itemCode = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IGE1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_IGE1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE1_OIGE_docId",
                        column: x => x.docId,
                        principalSchema: "INV",
                        principalTable: "OIGE",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE1_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IGE1_createdBy",
                schema: "INV",
                table: "IGE1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_IGE1_itemCode",
                schema: "INV",
                table: "IGE1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_IGE1_updatedBy",
                schema: "INV",
                table: "IGE1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_createdBy",
                schema: "INV",
                table: "OIGE",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_komId",
                schema: "INV",
                table: "OIGE",
                column: "komId");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_serieId",
                schema: "INV",
                table: "OIGE",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_updatedBy",
                schema: "INV",
                table: "OIGE",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_whsCode",
                schema: "INV",
                table: "OIGE",
                column: "whsCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IGE1",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OIGE",
                schema: "INV");
        }
    }
}
