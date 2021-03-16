﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddManufactersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OMRC",
                schema: "INV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    objType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    createdBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    updatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OMRC", x => x.id);
                    table.ForeignKey(
                        name: "FK_OMRC_AspNetUsers_createdBy",
                        column: x => x.createdBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OMRC_AspNetUsers_updatedBy",
                        column: x => x.updatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OMRC_OOBJ_objType",
                        column: x => x.objType,
                        principalSchema: "ADM",
                        principalTable: "OOBJ",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OMRC_createdBy",
                schema: "INV",
                table: "OMRC",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OMRC_objType",
                schema: "INV",
                table: "OMRC",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OMRC_updatedBy",
                schema: "INV",
                table: "OMRC",
                column: "updatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OMRC",
                schema: "INV");
        }
    }
}
