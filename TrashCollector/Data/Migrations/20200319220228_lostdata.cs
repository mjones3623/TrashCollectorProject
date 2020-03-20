using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class lostdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "787acd89-41c0-496f-9425-c65a8198e6a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8e578aa-c5fc-4915-8122-aa6829ac3025");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df854267-1552-4d7a-9bb1-e59c11abbd7c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15e60567-723c-4dac-b12e-53ffa96f6061", "89141b2a-7510-455d-a78b-f62d57bc9f0b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "722686ed-6b4d-4ecd-8ddd-c723e99b2582", "533e5f55-006e-4859-bf7d-a2885f4d13f9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8992686-3a67-4ebb-92ee-af23adbff175", "067ad2f3-dcc8-4561-bd5f-a9de6d05eed5", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e60567-723c-4dac-b12e-53ffa96f6061");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "722686ed-6b4d-4ecd-8ddd-c723e99b2582");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8992686-3a67-4ebb-92ee-af23adbff175");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8e578aa-c5fc-4915-8122-aa6829ac3025", "565ecc43-7a0c-4d18-a36d-e2ced531513b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "787acd89-41c0-496f-9425-c65a8198e6a3", "0252cd36-b59c-4681-b89c-8724fa4447ee", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df854267-1552-4d7a-9bb1-e59c11abbd7c", "ece6784f-cf10-48a6-8b3b-27da43df7570", "Customer", "CUSTOMER" });
        }
    }
}
