using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddItemsDispatchesTableAndDetails : Migration
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
                    objType = table.Column<int>(type: "int", nullable: false),
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
                    whsCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
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
                        name: "FK_OIGE_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OIGE_OWHS_whsCode",
                        column: x => x.whsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IGE1",
                schema: "INV",
                columns: table => new
                {
                    lineNum = table.Column<int>(type: "int", nullable: false),
                    docId = table.Column<int>(type: "int", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    docDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isClosed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    itemCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<float>(type: "real", nullable: false),
                    openQty = table.Column<float>(type: "real", nullable: false)
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
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IGE1_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    itemCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                        principalColumn: "itemCode",
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
                name: "IX_IGE1_objType",
                schema: "INV",
                table: "IGE1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_IGE1_updatedBy",
                schema: "INV",
                table: "IGE1",
                column: "updatedBy");

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
                name: "IX_OIGE_objType",
                schema: "INV",
                table: "OIGE",
                column: "objType");

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
                name: "IGE2",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "IGE1",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OIGE",
                schema: "INV");
        }
    }
}
