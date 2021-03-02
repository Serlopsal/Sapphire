using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class BreakingChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                schema: "ADM",
                table: "OOBJ",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "ADM",
                table: "OOBJ",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                schema: "ADM",
                table: "OOBJ",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "ADM",
                table: "OOBJ",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                schema: "INV",
                table: "OKOM",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "INV",
                table: "OKOM",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                schema: "INV",
                table: "OKOM",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "INV",
                table: "OKOM",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "whsCode",
                schema: "INV",
                table: "OIGN",
                type: "nvarchar(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "whsCode",
                schema: "INV",
                table: "OIGE",
                type: "nvarchar(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "itemCode",
                schema: "INV",
                table: "IGE2",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_createdBy",
                schema: "ADM",
                table: "OOBJ",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_updatedBy",
                schema: "ADM",
                table: "OOBJ",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OKOM_createdBy",
                schema: "INV",
                table: "OKOM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OKOM_updatedBy",
                schema: "INV",
                table: "OKOM",
                column: "updatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_OKOM_AspNetUsers_createdBy",
                schema: "INV",
                table: "OKOM",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OKOM_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OKOM",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OOBJ_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OOBJ",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OOBJ_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OOBJ",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OKOM_AspNetUsers_createdBy",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropForeignKey(
                name: "FK_OKOM_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropForeignKey(
                name: "FK_OOBJ_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropForeignKey(
                name: "FK_OOBJ_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropIndex(
                name: "IX_OOBJ_createdBy",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropIndex(
                name: "IX_OOBJ_updatedBy",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropIndex(
                name: "IX_OKOM_createdBy",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropIndex(
                name: "IX_OKOM_updatedBy",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropColumn(
                name: "createdAt",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropColumn(
                name: "createdAt",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.AlterColumn<string>(
                name: "whsCode",
                schema: "INV",
                table: "OIGN",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "whsCode",
                schema: "INV",
                table: "OIGE",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "itemCode",
                schema: "INV",
                table: "IGE2",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);
        }
    }
}
