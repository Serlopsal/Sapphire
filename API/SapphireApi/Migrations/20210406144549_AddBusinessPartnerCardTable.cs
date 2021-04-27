using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddBusinessPartnerCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "onlyCardType",
                table: "MKT_OCRG",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MKT_OCRD",
                columns: table => new
                {
                    cardCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    cardName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    cardType = table.Column<int>(type: "int", nullable: false),
                    cardGroupId = table.Column<int>(type: "int", nullable: false),
                    identifier = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    currCode = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    website = table.Column<string>(type: "text", nullable: true),
                    isLocked = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MKT_OCRD", x => x.cardCode);
                    table.ForeignKey(
                        name: "FK_MKT_OCRD_ADM_OCRN_currCode",
                        column: x => x.currCode,
                        principalTable: "ADM_OCRN",
                        principalColumn: "currCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRD_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRD_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRD_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MKT_OCRD_MKT_OCRG_cardGroupId",
                        column: x => x.cardGroupId,
                        principalTable: "MKT_OCRG",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRD_cardGroupId",
                table: "MKT_OCRD",
                column: "cardGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRD_createdBy",
                table: "MKT_OCRD",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRD_currCode",
                table: "MKT_OCRD",
                column: "currCode");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRD_objType",
                table: "MKT_OCRD",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_MKT_OCRD_updatedBy",
                table: "MKT_OCRD",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MKT_OCRD");

            migrationBuilder.DropColumn(
                name: "onlyCardType",
                table: "MKT_OCRG");
        }
    }
}
