using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SapphireApi.Migrations
{
    public partial class AddUomConverterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADM_OUGP",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fromOneId = table.Column<int>(type: "int", nullable: false),
                    toManyId = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<float>(type: "float", nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    createdBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedBy = table.Column<string>(type: "varchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_OUGP", x => x.id);
                    table.ForeignKey(
                        name: "FK_ADM_OUGP_ADM_OOBJ_objType",
                        column: x => x.objType,
                        principalTable: "ADM_OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OUGP_ADM_OUOM_fromOneId",
                        column: x => x.fromOneId,
                        principalTable: "ADM_OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OUGP_ADM_OUOM_toManyId",
                        column: x => x.toManyId,
                        principalTable: "ADM_OUOM",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OUGP_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ADM_OUGP_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OUGP_createdBy",
                table: "ADM_OUGP",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OUGP_fromOneId",
                table: "ADM_OUGP",
                column: "fromOneId");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OUGP_objType",
                table: "ADM_OUGP",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OUGP_toManyId",
                table: "ADM_OUGP",
                column: "toManyId");

            migrationBuilder.CreateIndex(
                name: "IX_ADM_OUGP_updatedBy",
                table: "ADM_OUGP",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADM_OUGP");
        }
    }
}
