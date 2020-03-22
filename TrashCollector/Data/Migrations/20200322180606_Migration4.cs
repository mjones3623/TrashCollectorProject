using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cd666c4-d7e9-4e90-be82-fb6415cc8d1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72e470df-5f41-4d4c-ad93-6e31dd202097");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7457ba0e-a66b-4750-ad5f-e432988c09f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bbf74dcc-a683-41ee-be85-a05fa5b9bdbd", "a674184d-c0d2-4961-a052-d307c8d0db64", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c561abb-89f0-4f26-9c11-5dd9da80a27a", "d8c5543d-2a25-4d10-806f-b9cc90c8b42b", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd1959b3-d118-4493-a419-8ff6a00a8ced", "317ac859-983f-4736-92c6-afd3a3a97a7b", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c561abb-89f0-4f26-9c11-5dd9da80a27a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbf74dcc-a683-41ee-be85-a05fa5b9bdbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd1959b3-d118-4493-a419-8ff6a00a8ced");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72e470df-5f41-4d4c-ad93-6e31dd202097", "2b153824-8fc9-4850-8fbb-0fea45da8166", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7457ba0e-a66b-4750-ad5f-e432988c09f1", "c8324cef-9b2b-41b3-b4a7-856856292df9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cd666c4-d7e9-4e90-be82-fb6415cc8d1b", "6d3b3e3c-c0e4-4057-87bf-b56a94fc61ad", "Customer", "CUSTOMER" });
        }
    }
}
