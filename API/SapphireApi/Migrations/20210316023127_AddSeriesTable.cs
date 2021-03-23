using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddSeriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "defaultSerieId",
                table: "ADM_OOBJ",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ADM_ONNM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    seriesName = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    firstNumber = table.Column<int>(type: "int", nullable: false),
                    lastNumber = table.Column<int>(type: "int", nullable: true),
                    nextNumber = table.Column<int>(type: "int", nullable: false),
                    isClosed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_ONNM", x => x.id);
                    table.ForeignKey(
                        name: "FK_ADM_ONNM_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_ONNM_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_ONNM_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OOBJ_defaultSerieId",
                table: "ADM_OOBJ",
                column: "defaultSerieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ONNM_createdBy",
                table: "ADM_ONNM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ONNM_objType",
                table: "ADM_ONNM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_ONNM_updatedBy",
                table: "ADM_ONNM",
                column: "updatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ADM_OOBJ_ADM_ONNM_defaultSerieId",
                table: "ADM_OOBJ",
                column: "defaultSerieId",
                principalTable: "ADM_ONNM",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ADM_OOBJ_ADM_ONNM_defaultSerieId",
                table: "ADM_OOBJ");

            migrationBuilder.DropTable(
                name: "ADM_ONNM");

            migrationBuilder.DropIndex(
                name: "IX_ADM_OOBJ_defaultSerieId",
                table: "ADM_OOBJ");

            migrationBuilder.DropColumn(
                name: "defaultSerieId",
                table: "ADM_OOBJ");
        }
    }
}
