using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddTransferRequestTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OWTQ",
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
                    table.PrimaryKey("PK_OWTQ", x => x.docId);
                    table.ForeignKey(
                        name: "FK_OWTQ_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTQ_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTQ_ONNM_serieId",
                        column: x => x.serieId,
                        principalSchema: "ADM",
                        principalTable: "ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTQ_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTQ_OWHS_fromWhsCode",
                        column: x => x.fromWhsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWTQ_OWHS_toWhsCode",
                        column: x => x.toWhsCode,
                        principalSchema: "INV",
                        principalTable: "OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WTQ1",
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
                    table.PrimaryKey("PK_WTQ1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_WTQ1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ1_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ1_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ1_OWTQ_docId",
                        column: x => x.docId,
                        principalSchema: "INV",
                        principalTable: "OWTQ",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WTQ2",
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
                    table.PrimaryKey("PK_WTQ2", x => x.id);
                    table.ForeignKey(
                        name: "FK_WTQ2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ2_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalSchema: "INV",
                        principalTable: "OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ2_OITM_itemCode",
                        column: x => x.itemCode,
                        principalSchema: "INV",
                        principalTable: "OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ2_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WTQ2_WTQ1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalSchema: "INV",
                        principalTable: "WTQ1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_createdBy",
                schema: "INV",
                table: "OWTQ",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_fromWhsCode",
                schema: "INV",
                table: "OWTQ",
                column: "fromWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_objType",
                schema: "INV",
                table: "OWTQ",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_serieId",
                schema: "INV",
                table: "OWTQ",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_toWhsCode",
                schema: "INV",
                table: "OWTQ",
                column: "toWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_updatedBy",
                schema: "INV",
                table: "OWTQ",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ1_createdBy",
                schema: "INV",
                table: "WTQ1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ1_itemCode",
                schema: "INV",
                table: "WTQ1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ1_objType",
                schema: "INV",
                table: "WTQ1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ1_updatedBy",
                schema: "INV",
                table: "WTQ1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ2_createdBy",
                schema: "INV",
                table: "WTQ2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ2_itemCode_batchNum",
                schema: "INV",
                table: "WTQ2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_WTQ2_masterId_masterLine",
                schema: "INV",
                table: "WTQ2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_WTQ2_objType",
                schema: "INV",
                table: "WTQ2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ2_updatedBy",
                schema: "INV",
                table: "WTQ2",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WTQ2",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "WTQ1",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OWTQ",
                schema: "INV");
        }
    }
}
