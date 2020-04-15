using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class jones1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b350f4ab-d40e-4d80-8df6-06a8518a6712", "a582ce39-b8e6-4c8e-994e-1f62e1cd7145", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93c7a053-5102-4ad0-8ac3-1d0dc8c1b788", "5945452f-154b-4ca6-b449-84c69eac9d5f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f40e8479-8cd1-4ce3-9313-dae5a5a05a76", "f4355bff-7cca-4135-b7d8-6abe7a3f0a82", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c7a053-5102-4ad0-8ac3-1d0dc8c1b788");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b350f4ab-d40e-4d80-8df6-06a8518a6712");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f40e8479-8cd1-4ce3-9313-dae5a5a05a76");

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
    }
}
