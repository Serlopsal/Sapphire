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
                values: new object[] { "cbb0f3cf-0290-4d56-a41f-01f8a99d991d", "0104755b-26f0-4be3-91fb-878ee5a9b101", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FullName" },
                values: new object[] { "426b62aa-425c-4431-8d11-a0157c2037ca", 0, "d00a84f0-9c91-4fe8-a177-f86eeca98b6d", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEImN59j9Szmx4wKigtPZ+Yvc5azuZGLsYX+rY3dL5mZ6lLn9JJXNcaxG5KFScq0QUA==", null, false, "885705f0-8450-4d7e-bf1c-605aa04616ca", false, "Admin", "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbb0f3cf-0290-4d56-a41f-01f8a99d991d", "426b62aa-425c-4431-8d11-a0157c2037ca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbb0f3cf-0290-4d56-a41f-01f8a99d991d", "426b62aa-425c-4431-8d11-a0157c2037ca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb0f3cf-0290-4d56-a41f-01f8a99d991d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "426b62aa-425c-4431-8d11-a0157c2037ca");
        }
    }
}
