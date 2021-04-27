using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddBusinessPartnerCardGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MKT_OCRG",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    groupName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    isLocked = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    defaultPriceListId = table.Column<int>(type: "int", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MKT_OCRG", x => x.id);
                    table.ForeignKey(
                        name: "FK_MKT_OCRG_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRG_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRG_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRG_MKT_OPLN_defaultPriceListId",
                        column: x => x.defaultPriceListId,
                        principalTable: "MKT_OPLN",
                        principalColumn: "listId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRG_createdBy",
                table: "MKT_OCRG",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRG_defaultPriceListId",
                table: "MKT_OCRG",
                column: "defaultPriceListId");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRG_objType",
                table: "MKT_OCRG",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRG_updatedBy",
                table: "MKT_OCRG",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MKT_OCRG");
        }
    }
}
