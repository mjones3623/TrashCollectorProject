using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cfed330-8416-4fcd-a152-d9931d2b2db2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90fa938d-49d3-4920-b51d-d6549f73a7e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce6ad3a8-c2bf-4968-a072-f0f06fee3caf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dd19556-8619-410c-b959-8a9f72b2f303", "580cd405-aae7-4453-9ba1-2a9d36044952", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c793c4c-e26c-4c2c-9003-02ab4d3d6f62", "c028acc6-4487-493b-8b1c-5511099c7aa1", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a3af51a-396e-4b17-9801-21d469478e3c", "3f07047c-b4dc-4c63-80d5-7fa310f680d8", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c793c4c-e26c-4c2c-9003-02ab4d3d6f62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a3af51a-396e-4b17-9801-21d469478e3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd19556-8619-410c-b959-8a9f72b2f303");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cfed330-8416-4fcd-a152-d9931d2b2db2", "55269bec-47ad-473b-8938-cff2b06f07f6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce6ad3a8-c2bf-4968-a072-f0f06fee3caf", "28f1165b-06e2-499c-948a-a8aea5f251c6", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90fa938d-49d3-4920-b51d-d6549f73a7e5", "3f77e686-7678-47de-a132-4c4c336e6dbe", "Customer", "CUSTOMER" });
        }
    }
}
