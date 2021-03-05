using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class BatchTransactionsAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OITL",
                schema: "INV",
                columns: table => new
                {
                    masterObjTypeId = table.Column<int>(type: "int", nullable: false),
                    masterId = table.Column<int>(type: "int", nullable: false),
                    masterSerieId = table.Column<int>(type: "int", nullable: false),
                    masterRef = table.Column<int>(type: "int", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OITL", x => new { x.masterObjTypeId, x.masterId });
                    table.ForeignKey(
                        name: "FK_OITL_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITL_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITL_ONNM_masterSerieId",
                        column: x => x.masterSerieId,
                        principalSchema: "ADM",
                        principalTable: "ONNM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITL_OOBJ_masterObjTypeId",
                        column: x => x.masterObjTypeId,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITL_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITL1",
                schema: "INV",
                columns: table => new
                {
                    masterObjTypeId = table.Column<int>(type: "int", nullable: false),
                    masterId = table.Column<int>(type: "int", nullable: false),
                    itemCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    batchId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<float>(type: "real", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITL1", x => new { x.masterObjTypeId, x.masterId, x.itemCode, x.batchId });
                    table.ForeignKey(
                        name: "FK_ITL1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITL1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITL1_OBTN_itemCode_batchId",
                        columns: x => new { x.itemCode, x.batchId },
                        principalSchema: "INV",
                        principalTable: "OBTN",
                        principalColumns: new[] { "itemCode", "batchNum" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITL1_OITL_masterObjTypeId_masterId",
                        columns: x => new { x.masterObjTypeId, x.masterId },
                        principalSchema: "INV",
                        principalTable: "OITL",
                        principalColumns: new[] { "masterObjTypeId", "masterId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITL1_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ITL1_createdBy",
                schema: "INV",
                table: "ITL1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ITL1_itemCode_batchId",
                schema: "INV",
                table: "ITL1",
                columns: new[] { "itemCode", "batchId" });

            migrationBuilder.CreateIndex(
                name: "IX_ITL1_objType",
                schema: "INV",
                table: "ITL1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ITL1_updatedBy",
                schema: "INV",
                table: "ITL1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITL_createdBy",
                schema: "INV",
                table: "OITL",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITL_masterSerieId",
                schema: "INV",
                table: "OITL",
                column: "masterSerieId");

            migrationBuilder.CreateIndex(
                name: "IX_OITL_objType",
                schema: "INV",
                table: "OITL",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OITL_updatedBy",
                schema: "INV",
                table: "OITL",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITL1",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OITL",
                schema: "INV");
        }
    }
}
