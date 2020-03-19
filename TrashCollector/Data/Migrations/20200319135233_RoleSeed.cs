using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class RoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf17b06-5e4e-4837-bbef-f3ebc79f8755");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0be1f712-f71e-4516-8172-567dd5dceae4", "6e8ecc17-cd77-465c-9379-8a8233724057", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a5edc7b-7a6f-493b-8acd-2b7def68471c", "5db29706-efb7-45e0-a75d-c3593dc7e4f8", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "646b98e7-b136-4fc2-baf0-a65df7081559", "b4612cbd-4aa7-4cbf-9cd7-64c1e1819487", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0be1f712-f71e-4516-8172-567dd5dceae4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "646b98e7-b136-4fc2-baf0-a65df7081559");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5edc7b-7a6f-493b-8acd-2b7def68471c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3cf17b06-5e4e-4837-bbef-f3ebc79f8755", "a3e6be57-2c42-4da7-b9ff-c5acb257fb69", "Admin", "ADMIN" });
        }
    }
}
