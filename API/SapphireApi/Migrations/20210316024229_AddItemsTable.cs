using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OITM",
                schema: "INV",
                columns: table => new
                {
                    itemCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    itemName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    itemsGroupId = table.Column<int>(type: "int", nullable: false),
                    barCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    purchaseItem = table.Column<bool>(type: "bit", nullable: false),
                    sellItem = table.Column<bool>(type: "bit", nullable: false),
                    inventoryItem = table.Column<bool>(type: "bit", nullable: false),
                    purchaseUomId = table.Column<int>(type: "int", nullable: false),
                    sellUomId = table.Column<int>(type: "int", nullable: false),
                    inventoryUomId = table.Column<int>(type: "int", nullable: false),
                    maxInvLvl = table.Column<float>(type: "real", nullable: true),
                    minInvLvl = table.Column<float>(type: "real", nullable: true),
                    mrcCode = table.Column<int>(type: "int", nullable: true),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OITM", x => x.itemCode);
                    table.ForeignKey(
                        name: "FK_OITM_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_OITB_itemsGroupId",
                        column: x => x.itemsGroupId,
                        principalSchema: "INV",
                        principalTable: "OITB",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_OMRC_mrcCode",
                        column: x => x.mrcCode,
                        principalSchema: "INV",
                        principalTable: "OMRC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_OUOM_inventoryUomId",
                        column: x => x.inventoryUomId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_OUOM_purchaseUomId",
                        column: x => x.purchaseUomId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OITM_OUOM_sellUomId",
                        column: x => x.sellUomId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OITM_createdBy",
                schema: "INV",
                table: "OITM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_inventoryUomId",
                schema: "INV",
                table: "OITM",
                column: "inventoryUomId");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_itemsGroupId",
                schema: "INV",
                table: "OITM",
                column: "itemsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_mrcCode",
                schema: "INV",
                table: "OITM",
                column: "mrcCode");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_objType",
                schema: "INV",
                table: "OITM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_purchaseUomId",
                schema: "INV",
                table: "OITM",
                column: "purchaseUomId");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_sellUomId",
                schema: "INV",
                table: "OITM",
                column: "sellUomId");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_updatedBy",
                schema: "INV",
                table: "OITM",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OITM",
                schema: "INV");
        }
    }
}
