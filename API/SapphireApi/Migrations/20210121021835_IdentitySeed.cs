using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class IdentitySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5999435d-5956-435a-b31d-83fd6fcc9950", "5c586d09-3afb-4f4d-9b8a-068251264803", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FullName" },
                values: new object[] { "40709ea0-0908-4bea-8468-433bd706cedd", 0, "e06c2418-01e3-4536-b55d-7dc3bf962a45", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEEcu9YJmr/MVLS5s+XfUqpzsEa4Cq9kfd8AEE0TBxo/+TTpDCLrCiNntqqkT9rTDJg==", null, false, "5b8390ab-d526-4849-b380-488c5275c7e3", false, "Admin", "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5999435d-5956-435a-b31d-83fd6fcc9950", "40709ea0-0908-4bea-8468-433bd706cedd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5999435d-5956-435a-b31d-83fd6fcc9950", "40709ea0-0908-4bea-8468-433bd706cedd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5999435d-5956-435a-b31d-83fd6fcc9950");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40709ea0-0908-4bea-8468-433bd706cedd");
        }
    }
}
