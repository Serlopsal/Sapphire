using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddTransferencesTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OWTR",
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
                    fromWhsCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    toWhsCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_OWTR", x => x.docId);
                    table.ForeignKey(
                        name: "FK_INV_OWTR_ADM_ONNM_serieId",
                        column: x => x.serieId,
                        principalTable: "ADM_ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTR_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTR_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTR_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTR_INV_OWHS_fromWhsCode",
                        column: x => x.fromWhsCode,
                        principalTable: "INV_OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTR_INV_OWHS_toWhsCode",
                        column: x => x.toWhsCode,
                        principalTable: "INV_OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_WTR1",
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
                    table.PrimaryKey("PK_INV_WTR1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_INV_WTR1_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR1_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR1_INV_OWTR_docId",
                        column: x => x.docId,
                        principalTable: "INV_OWTR",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_WTR2",
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
                    table.PrimaryKey("PK_INV_WTR2", x => x.id);
                    table.ForeignKey(
                        name: "FK_INV_WTR2_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR2_INV_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalTable: "INV_OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR2_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTR2_INV_WTR1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalTable: "INV_WTR1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTR_createdBy",
                table: "INV_OWTR",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTR_fromWhsCode",
                table: "INV_OWTR",
                column: "fromWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTR_objType",
                table: "INV_OWTR",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTR_serieId",
                table: "INV_OWTR",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTR_toWhsCode",
                table: "INV_OWTR",
                column: "toWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTR_updatedBy",
                table: "INV_OWTR",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR1_createdBy",
                table: "INV_WTR1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR1_itemCode",
                table: "INV_WTR1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR1_objType",
                table: "INV_WTR1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR1_updatedBy",
                table: "INV_WTR1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR2_createdBy",
                table: "INV_WTR2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR2_itemCode_batchNum",
                table: "INV_WTR2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR2_masterId_masterLine",
                table: "INV_WTR2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR2_objType",
                table: "INV_WTR2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTR2_updatedBy",
                table: "INV_WTR2",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_WTR2");

            migrationBuilder.DropTable(
                name: "INV_WTR1");

            migrationBuilder.DropTable(
                name: "INV_OWTR");
        }
    }
}
