using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class AddObjectsFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "WTR1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "WTQ1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OWTR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OWTQ",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OWHS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "ADM",
                table: "OUOM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "ADM",
                table: "OUGP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "ADM",
                table: "OOBJ",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OMRC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OKOM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OITM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OITB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OIGN",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OIGE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "ADM",
                table: "OCST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "ADM",
                table: "OCRY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "OBTN",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "ADM",
                table: "OADM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "IGN1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "objType",
                schema: "INV",
                table: "IGE1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WTR1_objType",
                schema: "INV",
                table: "WTR1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_WTQ1_objType",
                schema: "INV",
                table: "WTQ1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OWTR_objType",
                schema: "INV",
                table: "OWTR",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OWTQ_objType",
                schema: "INV",
                table: "OWTQ",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OWHS_objType",
                schema: "INV",
                table: "OWHS",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OUOM_objType",
                schema: "ADM",
                table: "OUOM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OUGP_objType",
                schema: "ADM",
                table: "OUGP",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OOBJ_objType",
                schema: "ADM",
                table: "OOBJ",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OMRC_objType",
                schema: "INV",
                table: "OMRC",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OKOM_objType",
                schema: "INV",
                table: "OKOM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OITM_objType",
                schema: "INV",
                table: "OITM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OITB_objType",
                schema: "INV",
                table: "OITB",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OIGN_objType",
                schema: "INV",
                table: "OIGN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OIGE_objType",
                schema: "INV",
                table: "OIGE",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OCST_objType",
                schema: "ADM",
                table: "OCST",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OCRY_objType",
                schema: "ADM",
                table: "OCRY",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OBTN_objType",
                schema: "INV",
                table: "OBTN",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_OADM_objType",
                schema: "ADM",
                table: "OADM",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_IGN1_objType",
                schema: "INV",
                table: "IGN1",
                column: "objType");

            migrationBuilder.CreateIndex(
                name: "IX_IGE1_objType",
                schema: "INV",
                table: "IGE1",
                column: "objType");

            migrationBuilder.AddForeignKey(
                name: "FK_IGE1_OOBJ_objType",
                schema: "INV",
                table: "IGE1",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IGN1_OOBJ_objType",
                schema: "INV",
                table: "IGN1",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OADM_OOBJ_objType",
                schema: "ADM",
                table: "OADM",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OBTN_OOBJ_objType",
                schema: "INV",
                table: "OBTN",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OCRY_OOBJ_objType",
                schema: "ADM",
                table: "OCRY",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OCST_OOBJ_objType",
                schema: "ADM",
                table: "OCST",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OIGE_OOBJ_objType",
                schema: "INV",
                table: "OIGE",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OIGN_OOBJ_objType",
                schema: "INV",
                table: "OIGN",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OITB_OOBJ_objType",
                schema: "INV",
                table: "OITB",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OITM_OOBJ_objType",
                schema: "INV",
                table: "OITM",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OKOM_OOBJ_objType",
                schema: "INV",
                table: "OKOM",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OMRC_OOBJ_objType",
                schema: "INV",
                table: "OMRC",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OOBJ_OOBJ_objType",
                schema: "ADM",
                table: "OOBJ",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OUGP_OOBJ_objType",
                schema: "ADM",
                table: "OUGP",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OUOM_OOBJ_objType",
                schema: "ADM",
                table: "OUOM",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OWHS_OOBJ_objType",
                schema: "INV",
                table: "OWHS",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OWTQ_OOBJ_objType",
                schema: "INV",
                table: "OWTQ",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OWTR_OOBJ_objType",
                schema: "INV",
                table: "OWTR",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WTQ1_OOBJ_objType",
                schema: "INV",
                table: "WTQ1",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WTR1_OOBJ_objType",
                schema: "INV",
                table: "WTR1",
                column: "objType",
                principalSchema: "ADM",
                principalTable: "OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IGE1_OOBJ_objType",
                schema: "INV",
                table: "IGE1");

            migrationBuilder.DropForeignKey(
                name: "FK_IGN1_OOBJ_objType",
                schema: "INV",
                table: "IGN1");

            migrationBuilder.DropForeignKey(
                name: "FK_OADM_OOBJ_objType",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropForeignKey(
                name: "FK_OBTN_OOBJ_objType",
                schema: "INV",
                table: "OBTN");

            migrationBuilder.DropForeignKey(
                name: "FK_OCRY_OOBJ_objType",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropForeignKey(
                name: "FK_OCST_OOBJ_objType",
                schema: "ADM",
                table: "OCST");

            migrationBuilder.DropForeignKey(
                name: "FK_OIGE_OOBJ_objType",
                schema: "INV",
                table: "OIGE");

            migrationBuilder.DropForeignKey(
                name: "FK_OIGN_OOBJ_objType",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropForeignKey(
                name: "FK_OITB_OOBJ_objType",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropForeignKey(
                name: "FK_OITM_OOBJ_objType",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropForeignKey(
                name: "FK_OKOM_OOBJ_objType",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropForeignKey(
                name: "FK_OMRC_OOBJ_objType",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropForeignKey(
                name: "FK_OOBJ_OOBJ_objType",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropForeignKey(
                name: "FK_OUGP_OOBJ_objType",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropForeignKey(
                name: "FK_OUOM_OOBJ_objType",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropForeignKey(
                name: "FK_OWHS_OOBJ_objType",
                schema: "INV",
                table: "OWHS");

            migrationBuilder.DropForeignKey(
                name: "FK_OWTQ_OOBJ_objType",
                schema: "INV",
                table: "OWTQ");

            migrationBuilder.DropForeignKey(
                name: "FK_OWTR_OOBJ_objType",
                schema: "INV",
                table: "OWTR");

            migrationBuilder.DropForeignKey(
                name: "FK_WTQ1_OOBJ_objType",
                schema: "INV",
                table: "WTQ1");

            migrationBuilder.DropForeignKey(
                name: "FK_WTR1_OOBJ_objType",
                schema: "INV",
                table: "WTR1");

            migrationBuilder.DropIndex(
                name: "IX_WTR1_objType",
                schema: "INV",
                table: "WTR1");

            migrationBuilder.DropIndex(
                name: "IX_WTQ1_objType",
                schema: "INV",
                table: "WTQ1");

            migrationBuilder.DropIndex(
                name: "IX_OWTR_objType",
                schema: "INV",
                table: "OWTR");

            migrationBuilder.DropIndex(
                name: "IX_OWTQ_objType",
                schema: "INV",
                table: "OWTQ");

            migrationBuilder.DropIndex(
                name: "IX_OWHS_objType",
                schema: "INV",
                table: "OWHS");

            migrationBuilder.DropIndex(
                name: "IX_OUOM_objType",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropIndex(
                name: "IX_OUGP_objType",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropIndex(
                name: "IX_OOBJ_objType",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropIndex(
                name: "IX_OMRC_objType",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropIndex(
                name: "IX_OKOM_objType",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropIndex(
                name: "IX_OITM_objType",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropIndex(
                name: "IX_OITB_objType",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropIndex(
                name: "IX_OIGN_objType",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropIndex(
                name: "IX_OIGE_objType",
                schema: "INV",
                table: "OIGE");

            migrationBuilder.DropIndex(
                name: "IX_OCST_objType",
                schema: "ADM",
                table: "OCST");

            migrationBuilder.DropIndex(
                name: "IX_OCRY_objType",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropIndex(
                name: "IX_OBTN_objType",
                schema: "INV",
                table: "OBTN");

            migrationBuilder.DropIndex(
                name: "IX_OADM_objType",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropIndex(
                name: "IX_IGN1_objType",
                schema: "INV",
                table: "IGN1");

            migrationBuilder.DropIndex(
                name: "IX_IGE1_objType",
                schema: "INV",
                table: "IGE1");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "WTR1");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "WTQ1");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OWTR");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OWTQ");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OWHS");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "ADM",
                table: "OUOM");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "ADM",
                table: "OUGP");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "ADM",
                table: "OOBJ");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OMRC");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OKOM");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OITM");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OITB");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OIGN");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OIGE");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "ADM",
                table: "OCST");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "ADM",
                table: "OCRY");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "OBTN");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "ADM",
                table: "OADM");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "IGN1");

            migrationBuilder.DropColumn(
                name: "objType",
                schema: "INV",
                table: "IGE1");
        }
    }
}
