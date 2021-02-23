using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddWarehouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OWHS",
                schema: "INV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    whsCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    whsName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OWHS", x => x.id);
                    table.ForeignKey(
                        name: "FK_OWHS_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWHS_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OWHS_OCST_cityId",
                        column: x => x.cityId,
                        principalSchema: "ADM",
                        principalTable: "OCST",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OWHS_cityId",
                schema: "INV",
                table: "OWHS",
                column: "cityId");

            migrationBuilder.CreateIndex(
                name: "IX_OWHS_createdBy",
                schema: "INV",
                table: "OWHS",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OWHS_updatedBy",
                schema: "INV",
                table: "OWHS",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OWHS_whsCode",
                schema: "INV",
                table: "OWHS",
                column: "whsCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OWHS",
                schema: "INV");
        }
    }
}
