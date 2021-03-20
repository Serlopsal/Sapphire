using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddBatchTransactionsTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OITL",
                columns: table => new
                {
                    masterObjTypeId = table.Column<int>(type: "int", nullable: false),
                    masterId = table.Column<int>(type: "int", nullable: false),
                    masterSerieId = table.Column<int>(type: "int", nullable: false),
                    masterRef = table.Column<int>(type: "int", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_OITL", x => new { x.masterObjTypeId, x.masterId });
                    table.ForeignKey(
                        name: "FK_INV_OITL_ADM_ONNM_masterSerieId",
                        column: x => x.masterSerieId,
                        principalTable: "ADM_ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITL_ADM_OOBJ_masterObjTypeId",
                        column: x => x.masterObjTypeId,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITL_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITL_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITL_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITL1",
                columns: table => new
                {
                    masterObjTypeId = table.Column<int>(type: "int", nullable: false),
                    masterId = table.Column<int>(type: "int", nullable: false),
                    itemCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    batchId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<float>(type: "float", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ITL1", x => new { x.masterObjTypeId, x.masterId, x.itemCode, x.batchId });
                    table.ForeignKey(
                        name: "FK_INV_ITL1_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ITL1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ITL1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ITL1_INV_OBTN_itemCode_batchId",
                        columns: x => new { x.itemCode, x.batchId },
                        principalTable: "INV_OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ITL1_INV_OITL_masterObjTypeId_masterId",
                        columns: x => new { x.masterObjTypeId, x.masterId },
                        principalTable: "INV_OITL",
                        principalColumns: new[] { "masterObjTypeId", "masterId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITL1_createdBy",
                table: "INV_ITL1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITL1_itemCode_batchId",
                table: "INV_ITL1",
                columns: new[] { "itemCode", "batchId" });

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITL1_objType",
                table: "INV_ITL1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITL1_updatedBy",
                table: "INV_ITL1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITL_createdBy",
                table: "INV_OITL",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITL_masterSerieId",
                table: "INV_OITL",
                column: "masterSerieId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITL_objType",
                table: "INV_OITL",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITL_updatedBy",
                table: "INV_OITL",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_ITL1");

            migrationBuilder.DropTable(
                name: "INV_OITL");
        }
    }
}
