using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddTransferencesTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OWTR",
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
                    fromWhsCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    toWhsCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OWTR", x => x.docId);
                    table.ForeignKey(
                        name: "FK_OWTR_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTR_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTR_ONNM_serieId",
                        column: x => x.serieId,
                        principalSchema: "ADM",
                        principalTable: "ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTR_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTR_OWHS_fromWhsCode",
                        column: x => x.fromWhsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTR_OWHS_toWhsCode",
                        column: x => x.toWhsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WTR1",
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
                    table.PrimaryKey("PK_WTR1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_WTR1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR1_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR1_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR1_OWTR_docId",
                        column: x => x.docId,
                        principalSchema: "INV",
                        principalTable: "OWTR",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WTR2",
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
                    table.PrimaryKey("PK_WTR2", x => x.id);
                    table.ForeignKey(
                        name: "FK_WTR2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR2_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalSchema: "INV",
                        principalTable: "OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR2_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR2_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTR2_WTR1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalSchema: "INV",
                        principalTable: "WTR1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_createdBy",
                schema: "INV",
                table: "OWTR",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_fromWhsCode",
                schema: "INV",
                table: "OWTR",
                column: "fromWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_objType",
                schema: "INV",
                table: "OWTR",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_serieId",
                schema: "INV",
                table: "OWTR",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_toWhsCode",
                schema: "INV",
                table: "OWTR",
                column: "toWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_updatedBy",
                schema: "INV",
                table: "OWTR",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTR1_createdBy",
                schema: "INV",
                table: "WTR1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTR1_itemCode",
                schema: "INV",
                table: "WTR1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_WTR1_objType",
                schema: "INV",
                table: "WTR1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_WTR1_updatedBy",
                schema: "INV",
                table: "WTR1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTR2_createdBy",
                schema: "INV",
                table: "WTR2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTR2_itemCode_batchNum",
                schema: "INV",
                table: "WTR2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_WTR2_masterId_masterLine",
                schema: "INV",
                table: "WTR2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_WTR2_objType",
                schema: "INV",
                table: "WTR2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_WTR2_updatedBy",
                schema: "INV",
                table: "WTR2",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WTR2",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "WTR1",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OWTR",
                schema: "INV");
        }
    }
}
