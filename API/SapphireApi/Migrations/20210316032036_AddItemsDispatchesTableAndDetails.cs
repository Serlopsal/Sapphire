using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddItemsDispatchesTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OIGE",
                columns: table => new
                {
                    docId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    docDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    isCanceled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    isPrinted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    isClosed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    docNum = table.Column<int>(type: "int", nullable: false),
                    reference = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    comment = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    serieId = table.Column<int>(type: "int", nullable: false),
                    komId = table.Column<int>(type: "int", nullable: false),
                    whsCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_OIGE", x => x.docId);
                    table.ForeignKey(
                        name: "FK_INV_OIGE_ADM_ONNM_serieId",
                        column: x => x.serieId,
                        principalTable: "ADM_ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGE_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGE_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGE_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGE_INV_OKOM_komId",
                        column: x => x.komId,
                        principalTable: "INV_OKOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGE_INV_OWHS_whsCode",
                        column: x => x.whsCode,
                        principalTable: "INV_OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_IGE1",
                columns: table => new
                {
                    lineNum = table.Column<int>(type: "int", nullable: false),
                    docId = table.Column<int>(type: "int", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    docDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    isClosed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    itemCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<float>(type: "float", nullable: false),
                    openQty = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_IGE1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_INV_IGE1_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE1_INV_OIGE_docId",
                        column: x => x.docId,
                        principalTable: "INV_OIGE",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE1_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_IGE2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    batchNum = table.Column<string>(type: "varchar(50)", nullable: false),
                    itemCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    masterId = table.Column<int>(type: "int", nullable: false),
                    masterLine = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<float>(type: "float", nullable: false),
                    openQty = table.Column<float>(type: "float", nullable: false),
                    isClosed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_IGE2", x => x.id);
                    table.ForeignKey(
                        name: "FK_INV_IGE2_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE2_INV_IGE1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalTable: "INV_IGE1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE2_INV_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalTable: "INV_OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGE2_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE1_createdBy",
                table: "INV_IGE1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE1_itemCode",
                table: "INV_IGE1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE1_objType",
                table: "INV_IGE1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE1_updatedBy",
                table: "INV_IGE1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE2_createdBy",
                table: "INV_IGE2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE2_itemCode_batchNum",
                table: "INV_IGE2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE2_masterId_masterLine",
                table: "INV_IGE2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE2_objType",
                table: "INV_IGE2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGE2_updatedBy",
                table: "INV_IGE2",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGE_createdBy",
                table: "INV_OIGE",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGE_komId",
                table: "INV_OIGE",
                column: "komId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGE_objType",
                table: "INV_OIGE",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGE_serieId",
                table: "INV_OIGE",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGE_updatedBy",
                table: "INV_OIGE",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGE_whsCode",
                table: "INV_OIGE",
                column: "whsCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_IGE2");

            migrationBuilder.DropTable(
                name: "INV_IGE1");

            migrationBuilder.DropTable(
                name: "INV_OIGE");
        }
    }
}
