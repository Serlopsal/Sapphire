using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddUomConverterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UomConverter",
                schema: "ADM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromOneId = table.Column<int>(type: "int", nullable: false),
                    toManyId = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<float>(type: "real", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UomConverter", x => x.id);
                    table.ForeignKey(
                        name: "FK_UomConverter_UOM_fromOneId",
                        column: x => x.fromOneId,
                        principalSchema: "ADM",
                        principalTable: "UOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UomConverter_UOM_toManyId",
                        column: x => x.toManyId,
                        principalSchema: "ADM",
                        principalTable: "UOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UomConverter_fromOneId",
                schema: "ADM",
                table: "UomConverter",
                column: "fromOneId");

            migrationBuilder.CreateIndex(
                name: "IX_UomConverter_toManyId",
                schema: "ADM",
                table: "UomConverter",
                column: "toManyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UomConverter",
                schema: "ADM");
        }
    }
}
