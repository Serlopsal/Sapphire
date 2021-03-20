using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddTransferRequestTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OWTQ",
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
                    table.PrimaryKey("PK_INV_OWTQ", x => x.docId);
                    table.ForeignKey(
                        name: "FK_INV_OWTQ_ADM_ONNM_serieId",
                        column: x => x.serieId,
                        principalTable: "ADM_ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTQ_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTQ_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTQ_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTQ_INV_OWHS_fromWhsCode",
                        column: x => x.fromWhsCode,
                        principalTable: "INV_OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OWTQ_INV_OWHS_toWhsCode",
                        column: x => x.toWhsCode,
                        principalTable: "INV_OWHS",
                        principalColumn: "whsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_WTQ1",
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
                    table.PrimaryKey("PK_INV_WTQ1", x => new { x.docId, x.lineNum });
                    table.ForeignKey(
                        name: "FK_INV_WTQ1_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ1_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ1_INV_OWTQ_docId",
                        column: x => x.docId,
                        principalTable: "INV_OWTQ",
                        principalColumn: "docId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_WTQ2",
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
                    table.PrimaryKey("PK_INV_WTQ2", x => x.id);
                    table.ForeignKey(
                        name: "FK_INV_WTQ2_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ2_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ2_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ2_INV_OBTN_itemCode_batchNum",
                        columns: x => new { x.itemCode, x.batchNum },
                        principalTable: "INV_OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ2_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_WTQ2_INV_WTQ1_masterId_masterLine",
                        columns: x => new { x.masterId, x.masterLine },
                        principalTable: "INV_WTQ1",
                        principalColumns: new[] { "docId", "lineNum" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTQ_createdBy",
                table: "INV_OWTQ",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTQ_fromWhsCode",
                table: "INV_OWTQ",
                column: "fromWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTQ_objType",
                table: "INV_OWTQ",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTQ_serieId",
                table: "INV_OWTQ",
                column: "serieId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTQ_toWhsCode",
                table: "INV_OWTQ",
                column: "toWhsCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OWTQ_updatedBy",
                table: "INV_OWTQ",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ1_createdBy",
                table: "INV_WTQ1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ1_itemCode",
                table: "INV_WTQ1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ1_objType",
                table: "INV_WTQ1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ1_updatedBy",
                table: "INV_WTQ1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ2_createdBy",
                table: "INV_WTQ2",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ2_itemCode_batchNum",
                table: "INV_WTQ2",
                columns: new[] { "itemCode", "batchNum" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ2_masterId_masterLine",
                table: "INV_WTQ2",
                columns: new[] { "masterId", "masterLine" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ2_objType",
                table: "INV_WTQ2",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_WTQ2_updatedBy",
                table: "INV_WTQ2",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_WTQ2");

            migrationBuilder.DropTable(
                name: "INV_WTQ1");

            migrationBuilder.DropTable(
                name: "INV_OWTQ");
        }
    }
}
