using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class Signing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "ADM",
                table: "OUOM",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "ADM",
                table: "OUOM",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "ADM",
                table: "OUGP",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "ADM",
                table: "OUGP",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "INV",
                table: "OMRC",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "INV",
                table: "OMRC",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "INV",
                table: "OITM",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "INV",
                table: "OITM",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "INV",
                table: "OITB",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "INV",
                table: "OITB",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "ADM",
                table: "OCRY",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "ADM",
                table: "OCRY",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                schema: "ADM",
                table: "OADM",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedBy",
                schema: "ADM",
                table: "OADM",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OUOM_createdBy",
                schema: "ADM",
                table: "OUOM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OUOM_updatedBy",
                schema: "ADM",
                table: "OUOM",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_createdBy",
                schema: "ADM",
                table: "OUGP",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_updatedBy",
                schema: "ADM",
                table: "OUGP",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OMRC_createdBy",
                schema: "INV",
                table: "OMRC",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OMRC_updatedBy",
                schema: "INV",
                table: "OMRC",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_createdBy",
                schema: "INV",
                table: "OITM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_updatedBy",
                schema: "INV",
                table: "OITM",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITB_createdBy",
                schema: "INV",
                table: "OITB",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OITB_updatedBy",
                schema: "INV",
                table: "OITB",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OCRY_createdBy",
                schema: "ADM",
                table: "OCRY",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OCRY_updatedBy",
                schema: "ADM",
                table: "OCRY",
                column: "updatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_createdBy",
                schema: "ADM",
                table: "OADM",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_updatedBy",
                schema: "ADM",
                table: "OADM",
                column: "updatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_OADM_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OADM",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OADM_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OADM",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OCRY_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OCRY",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OCRY_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OCRY",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OITB_AspNetUsers_createdBy",
                schema: "INV",
                table: "OITB",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OITB_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OITB",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OITM_AspNetUsers_createdBy",
                schema: "INV",
                table: "OITM",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OITM_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OITM",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OMRC_AspNetUsers_createdBy",
                schema: "INV",
                table: "OMRC",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OMRC_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OMRC",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OUGP_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OUGP",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OUGP_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OUGP",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OUOM_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OUOM",
                column: "createdBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OUOM_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OUOM",
                column: "updatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OADM_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropForeignKey(
                name: "FK_OADM_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropForeignKey(
                name: "FK_OCRY_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropForeignKey(
                name: "FK_OCRY_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropForeignKey(
                name: "FK_OITB_AspNetUsers_createdBy",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropForeignKey(
                name: "FK_OITB_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropForeignKey(
                name: "FK_OITM_AspNetUsers_createdBy",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropForeignKey(
                name: "FK_OITM_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropForeignKey(
                name: "FK_OMRC_AspNetUsers_createdBy",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropForeignKey(
                name: "FK_OMRC_AspNetUsers_updatedBy",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropForeignKey(
                name: "FK_OUGP_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropForeignKey(
                name: "FK_OUGP_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropForeignKey(
                name: "FK_OUOM_AspNetUsers_createdBy",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropForeignKey(
                name: "FK_OUOM_AspNetUsers_updatedBy",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropIndex(
                name: "IX_OUOM_createdBy",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropIndex(
                name: "IX_OUOM_updatedBy",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropIndex(
                name: "IX_OUGP_createdBy",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropIndex(
                name: "IX_OUGP_updatedBy",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropIndex(
                name: "IX_OMRC_createdBy",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropIndex(
                name: "IX_OMRC_updatedBy",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropIndex(
                name: "IX_OITM_createdBy",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropIndex(
                name: "IX_OITM_updatedBy",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropIndex(
                name: "IX_OITB_createdBy",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropIndex(
                name: "IX_OITB_updatedBy",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropIndex(
                name: "IX_OCRY_createdBy",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropIndex(
                name: "IX_OCRY_updatedBy",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropIndex(
                name: "IX_OADM_createdBy",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropIndex(
                name: "IX_OADM_updatedBy",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropColumn(
                name: "createdBy",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropColumn(
                name: "updatedBy",
                schema: "ADM",
                table: "OADM");
        }
    }
}
