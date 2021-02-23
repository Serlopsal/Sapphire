using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddItemsReceiptsAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OIGN",
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
                    table.PrimaryKey("PK_OIGN", x => x.docId);
                    table.ForeignKey(
                        name: "FK_OIGN_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGN_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGN_OKOM_komId",
                        column: x => x.komId,
                        principalSchema: "INV",
                        principalTable: "OKOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGN_ONNM_serieId",
                        column: x => x.serieId,
                        principalSchema: "ADM",
                        principalTable: "ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGN_OWHS_whsCode",
                        column: x => x.whsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IGN1",
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
                    table.PrimaryKey("PK_IGN1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_IGN1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGN1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGN1_OIGN_docId",
                        column: x => x.docId,
                        principalSchema: "INV",
                        principalTable: "OIGN",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGN1_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IGN1_createdBy",
                schema: "INV",
                table: "IGN1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_IGN1_itemCode",
                schema: "INV",
                table: "IGN1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_IGN1_updatedBy",
                schema: "INV",
                table: "IGN1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_createdBy",
                schema: "INV",
                table: "OIGN",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_komId",
                schema: "INV",
                table: "OIGN",
                column: "komId");

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_serieId",
                schema: "INV",
                table: "OIGN",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_updatedBy",
                schema: "INV",
                table: "OIGN",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_whsCode",
                schema: "INV",
                table: "OIGN",
                column: "whsCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IGN1",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OIGN",
                schema: "INV");
        }
    }
}
