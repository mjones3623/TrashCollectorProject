using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32657419-6afc-4947-970a-1dfd42e65bef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4df975df-6622-4455-a4aa-01f83c64c970");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3602ea1-2461-4671-b066-1b2902244832");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPickup",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LastPickup",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4df975df-6622-4455-a4aa-01f83c64c970", "769b3497-f6af-404c-b20d-b63a8068b0b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3602ea1-2461-4671-b066-1b2902244832", "78659463-e154-4785-9a87-77c301c3f108", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32657419-6afc-4947-970a-1dfd42e65bef", "a7c6f3b7-43b7-4379-be9a-0b1a359e1c6a", "Customer", "CUSTOMER" });
        }
    }
}
