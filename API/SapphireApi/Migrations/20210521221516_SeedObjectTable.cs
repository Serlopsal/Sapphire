using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class SeedObjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ADM_OOBJ",
                columns: new[] { "id", "code", "createdBy", "defaultSerieId", "description", "docPrefix", "objType", "updatedBy" },
                values: new object[] { 101, "OOBJ", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Objects", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" });

            migrationBuilder.InsertData(
                table: "ADM_OOBJ",
                columns: new[] { "id", "code", "createdBy", "defaultSerieId", "description", "docPrefix", "objType", "updatedBy" },
                values: new object[,]
                {
                    { 1, "OADM", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Companies", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 300, "OPLN", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Price Lists", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 224, "OWTR", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Items Warehouse Transference", "TR", 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 223, "OWTQ", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Items Warehouse Transfer Request", "TQ", 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 222, "OIGE", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Items Dispatches", "ID", 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 221, "OIGN", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Items Receipts", "IR", 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 220, "OITL", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Batches Transactions", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 212, "OBTN", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Item's Batches", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 211, "OITM", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Items", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 210, "OITB", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Item's Groups", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 203, "OKOM", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Kind Of Movements", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 202, "OMRC", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Manufacter", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 201, "OWHS", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Warehouses", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 131, "ORTT", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Currencies Rates", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 130, "OCRN", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Currencies", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 121, "OUGP", "40709ea0-0908-4bea-8468-433bd706cedd", null, "UOM Converters", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 120, "OUOM", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Units Of Measure", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 111, "OCST", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Cities", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 110, "OCRY", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Countries", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 102, "ONNM", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Series", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 310, "OCRG", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Bussiness Partners Groups", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 311, "OCRD", "40709ea0-0908-4bea-8468-433bd706cedd", null, "Bussiness Partners Cards", null, 101, "40709ea0-0908-4bea-8468-433bd706cedd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 311);

            migrationBuilder.DropForeignKey(
                name: "FK_ADM_OOBJ_ADM_OOBJ_objType",
                table: "ADM_OOBJ");

            migrationBuilder.DeleteData(
                table: "ADM_OOBJ",
                keyColumn: "id",
                keyValue: 101);
            
            migrationBuilder.AddForeignKey(
                name: "FK_ADM_OOBJ_ADM_OOBJ_objType",
                table: "ADM_OOBJ",
                column: "objType",
                principalTable: "ADM_OOBJ",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
