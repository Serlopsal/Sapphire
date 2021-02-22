using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class MRCTable_ITBTable_ITMTable_FKUOM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "INV");

            migrationBuilder.CreateTable(
                name: "OITB",
                schema: "INV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itmsGrpNam = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OMRC",
                schema: "INV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacter", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OITM",
                schema: "INV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_ItemsGroup_itemsGroupId",
                        column: x => x.itemsGroupId,
                        principalSchema: "INV",
                        principalTable: "OITB",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Manufacter_mrcCode",
                        column: x => x.mrcCode,
                        principalSchema: "INV",
                        principalTable: "OMRC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_UOM_inventoryUomId",
                        column: x => x.inventoryUomId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_UOM_purchaseUomId",
                        column: x => x.purchaseUomId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_UOM_sellUomId",
                        column: x => x.sellUomId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_inventoryUomId",
                schema: "INV",
                table: "OITM",
                column: "inventoryUomId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_itemsGroupId",
                schema: "INV",
                table: "OITM",
                column: "itemsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_mrcCode",
                schema: "INV",
                table: "OITM",
                column: "mrcCode");

            migrationBuilder.CreateIndex(
                name: "IX_Items_purchaseUomId",
                schema: "INV",
                table: "OITM",
                column: "purchaseUomId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_sellUomId",
                schema: "INV",
                table: "OITM",
                column: "sellUomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OITM",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OITB",
                schema: "INV");

            migrationBuilder.DropTable(
                name: "OMRC",
                schema: "INV");
        }
    }
}
