using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class ObjectAndSeriesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OOBJ",
                schema: "ADM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    docPrefix = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    defaultSerieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OOBJ", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ONNM",
                schema: "ADM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    objType = table.Column<int>(type: "int", nullable: false),
                    seriesName = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    firstNumber = table.Column<int>(type: "int", nullable: false),
                    lastNumber = table.Column<int>(type: "int", nullable: true),
                    nextNumber = table.Column<int>(type: "int", nullable: false),
                    isClosed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONNM", x => x.id);
                    table.ForeignKey(
                        name: "FK_ONNM_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ONNM_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ONNM_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ONNM_createdBy",
                schema: "ADM",
                table: "ONNM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ONNM_objType",
                schema: "ADM",
                table: "ONNM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ONNM_updatedBy",
                schema: "ADM",
                table: "ONNM",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_defaultSerieId",
                schema: "ADM",
                table: "OOBJ",
                column: "defaultSerieId",
                unique: true,
                filter: "[defaultSerieId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_OOBJ_ONNM_defaultSerieId",
                schema: "ADM",
                table: "OOBJ",
                column: "defaultSerieId",
                principalSchema: "ADM",
                principalTable: "ONNM",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ONNM_OOBJ_objType",
                schema: "ADM",
                table: "ONNM");

            migrationBuilder.DropTable(
                name: "OOBJ",
                schema: "ADM");

            migrationBuilder.DropTable(
                name: "ONNM",
                schema: "ADM");
        }
    }
}
