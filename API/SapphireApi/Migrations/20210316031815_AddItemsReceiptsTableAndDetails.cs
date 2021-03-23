using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddItemsReceiptsTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OIGN",
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
                    table.PrimaryKey("PK_INV_OIGN", x => x.docId);
                    table.ForeignKey(
                        name: "FK_INV_OIGN_ADM_ONNM_serieId",
                        column: x => x.serieId,
                        principalTable: "ADM_ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGN_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGN_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGN_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGN_INV_OKOM_komId",
                        column: x => x.komId,
                        principalTable: "INV_OKOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OIGN_INV_OWHS_whsCode",
                        column: x => x.whsCode,
                        principalTable: "INV_OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_IGN1",
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
                    table.PrimaryKey("PK_INV_IGN1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_INV_IGN1_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN1_INV_OIGN_docId",
                        column: x => x.docId,
                        principalTable: "INV_OIGN",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN1_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_IGN2",
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
                    table.PrimaryKey("PK_INV_IGN2", x => x.id);
                    table.ForeignKey(
                        name: "FK_INV_IGN2_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN2_INV_IGN1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalTable: "INV_IGN1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN2_INV_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalTable: "INV_OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_IGN2_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN1_createdBy",
                table: "INV_IGN1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN1_itemCode",
                table: "INV_IGN1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN1_objType",
                table: "INV_IGN1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN1_updatedBy",
                table: "INV_IGN1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN2_createdBy",
                table: "INV_IGN2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN2_itemCode_batchNum",
                table: "INV_IGN2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN2_masterId_masterLine",
                table: "INV_IGN2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN2_objType",
                table: "INV_IGN2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_IGN2_updatedBy",
                table: "INV_IGN2",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGN_createdBy",
                table: "INV_OIGN",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGN_komId",
                table: "INV_OIGN",
                column: "komId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGN_objType",
                table: "INV_OIGN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGN_serieId",
                table: "INV_OIGN",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGN_updatedBy",
                table: "INV_OIGN",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OIGN_whsCode",
                table: "INV_OIGN",
                column: "whsCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_IGN2");

            migrationBuilder.DropTable(
                name: "INV_IGN1");

            migrationBuilder.DropTable(
                name: "INV_OIGN");
        }
    }
}
