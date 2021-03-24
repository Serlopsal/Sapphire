using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddPriceListTableAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MKT_OPLN",
                columns: table => new
                {
                    listId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    listName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    curCode = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    baseList = table.Column<int>(type: "int", nullable: true),
                    factor = table.Column<float>(type: "float", nullable: true),
                    isLocked = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MKT_OPLN", x => x.listId);
                    table.ForeignKey(
                        name: "FK_MKT_OPLN_ADM_OCRN_curCode",
                        column: x => x.curCode,
                        principalTable: "ADM_OCRN",
                        principalColumn: "currCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OPLN_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OPLN_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OPLN_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MKT_ITM1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    priceListId = table.Column<int>(type: "int", nullable: false),
                    itemCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    price = table.Column<float>(type: "float", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MKT_ITM1", x => x.id);
                    table.ForeignKey(
                        name: "FK_MKT_ITM1_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_ITM1_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_ITM1_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_ITM1_INV_OITM_itemCode",
                        column: x => x.itemCode,
                        principalTable: "INV_OITM",
                        principalColumn: "itemCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_ITM1_MKT_OPLN_priceListId",
                        column: x => x.priceListId,
                        principalTable: "MKT_OPLN",
                        principalColumn: "listId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MKT_ITM1_createdBy",
                table: "MKT_ITM1",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_ITM1_itemCode",
                table: "MKT_ITM1",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_ITM1_objType",
                table: "MKT_ITM1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_ITM1_priceListId",
                table: "MKT_ITM1",
                column: "priceListId");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_ITM1_updatedBy",
                table: "MKT_ITM1",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OPLN_createdBy",
                table: "MKT_OPLN",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OPLN_curCode",
                table: "MKT_OPLN",
                column: "curCode");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OPLN_objType",
                table: "MKT_OPLN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OPLN_updatedBy",
                table: "MKT_OPLN",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MKT_ITM1");

            migrationBuilder.DropTable(
                name: "MKT_OPLN");
        }
    }
}
