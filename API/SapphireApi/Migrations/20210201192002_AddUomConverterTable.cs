using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddUomConverterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OUGP",
                schema: "ADM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromOneId = table.Column<int>(type: "int", nullable: false),
                    toManyId = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<float>(type: "real", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OUGP", x => x.id);
                    table.ForeignKey(
                        name: "FK_OUGP_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OUGP_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OUGP_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OUGP_OUOM_fromOneId",
                        column: x => x.fromOneId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OUGP_OUOM_toManyId",
                        column: x => x.toManyId,
                        principalSchema: "ADM",
                        principalTable: "OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_createdBy",
                schema: "ADM",
                table: "OUGP",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_fromOneId",
                schema: "ADM",
                table: "OUGP",
                column: "fromOneId");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_objType",
                schema: "ADM",
                table: "OUGP",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_toManyId",
                schema: "ADM",
                table: "OUGP",
                column: "toManyId");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_updatedBy",
                schema: "ADM",
                table: "OUGP",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OUGP",
                schema: "ADM");
        }
    }
}
