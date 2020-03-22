using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8771d0-c6db-4f5a-8b68-67822538dcaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4490ef9-09b4-43ef-b90c-d036ad00e338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f45c0fec-49b9-4fa5-8afc-99fec0418ca1");

            migrationBuilder.AddColumn<DateTime>(
                name: "QueryDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc636aec-2bc5-4e20-b12b-1399d1e9defa", "6007bd04-5280-42f6-95ef-cb284268e64b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e1cdb29-a684-4a7a-8488-816eb147c2ac", "e1c66834-0ec8-481a-baa1-2600a58f5146", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3327d833-3d3e-4a6f-a851-0ffddff12494", "9eaa95a4-94ef-45f8-ad1e-ca7f08782d02", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3327d833-3d3e-4a6f-a851-0ffddff12494");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e1cdb29-a684-4a7a-8488-816eb147c2ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc636aec-2bc5-4e20-b12b-1399d1e9defa");

            migrationBuilder.DropColumn(
                name: "QueryDate",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e8771d0-c6db-4f5a-8b68-67822538dcaa", "a0f7034a-3ccd-4d64-97bb-c669be4a9409", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4490ef9-09b4-43ef-b90c-d036ad00e338", "f5c3c66a-4862-4345-9afa-a7a6205db9e8", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f45c0fec-49b9-4fa5-8afc-99fec0418ca1", "9abdf788-ccc4-4447-ae8c-b5d6d99dd280", "Customer", "CUSTOMER" });
        }
    }
}
