using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddObjectsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ADM");

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
                    defaultSerieId = table.Column<int>(type: "int", nullable: true),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OOBJ", x => x.id);
                    table.ForeignKey(
                        name: "FK_OOBJ_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OOBJ_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OOBJ_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_createdBy",
                schema: "ADM",
                table: "OOBJ",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_objType",
                schema: "ADM",
                table: "OOBJ",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_updatedBy",
                schema: "ADM",
                table: "OOBJ",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OOBJ",
                schema: "ADM");
        }
    }
}
