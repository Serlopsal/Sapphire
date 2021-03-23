using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_OITM",
                columns: table => new
                {
                    itemCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    itemName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    itemsGroupId = table.Column<int>(type: "int", nullable: false),
                    barCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    purchaseItem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sellItem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    inventoryItem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    purchaseUomId = table.Column<int>(type: "int", nullable: false),
                    sellUomId = table.Column<int>(type: "int", nullable: false),
                    inventoryUomId = table.Column<int>(type: "int", nullable: false),
                    maxInvLvl = table.Column<float>(type: "float", nullable: true),
                    minInvLvl = table.Column<float>(type: "float", nullable: true),
                    mrcCode = table.Column<int>(type: "int", nullable: true),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_OITM", x => x.itemCode);
                    table.ForeignKey(
                        name: "FK_INV_OITM_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_ADM_OUOM_inventoryUomId",
                        column: x => x.inventoryUomId,
                        principalTable: "ADM_OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_ADM_OUOM_purchaseUomId",
                        column: x => x.purchaseUomId,
                        principalTable: "ADM_OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_ADM_OUOM_sellUomId",
                        column: x => x.sellUomId,
                        principalTable: "ADM_OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_INV_OITB_itemsGroupId",
                        column: x => x.itemsGroupId,
                        principalTable: "INV_OITB",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_OITM_INV_OMRC_mrcCode",
                        column: x => x.mrcCode,
                        principalTable: "INV_OMRC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_createdBy",
                table: "INV_OITM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_inventoryUomId",
                table: "INV_OITM",
                column: "inventoryUomId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_itemsGroupId",
                table: "INV_OITM",
                column: "itemsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_mrcCode",
                table: "INV_OITM",
                column: "mrcCode");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_objType",
                table: "INV_OITM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_purchaseUomId",
                table: "INV_OITM",
                column: "purchaseUomId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_sellUomId",
                table: "INV_OITM",
                column: "sellUomId");

            migrationBuilder.CreateIndex(
                name: "IX_INV_OITM_updatedBy",
                table: "INV_OITM",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_OITM");
        }
    }
}
