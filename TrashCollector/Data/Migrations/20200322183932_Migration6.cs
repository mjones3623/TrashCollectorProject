using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "748e3b07-5934-494b-84d3-b68075f58600");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5b1bed3-4b75-4bf1-9b08-3e783b6a9d56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e91c367c-3ea8-47ae-83f2-cb18b577763e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac3860f7-d52f-49f1-8795-d2b40199571a", "814dca60-718d-4c35-a95c-b880e9c81e84", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "332924ca-f7c1-43ae-b7aa-20c404951954", "0c6870ef-c334-48a0-8002-3a9160b09d2a", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75663da6-1d4c-4aae-a968-7309ef968e03", "1aa8aaed-7735-460b-bdf9-217c37430750", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "332924ca-f7c1-43ae-b7aa-20c404951954");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75663da6-1d4c-4aae-a968-7309ef968e03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac3860f7-d52f-49f1-8795-d2b40199571a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e91c367c-3ea8-47ae-83f2-cb18b577763e", "e9afb68a-f52e-4e6e-9370-117ad54585e1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "748e3b07-5934-494b-84d3-b68075f58600", "1f0c6c92-e6f6-405d-af2e-12cfeffbbba5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5b1bed3-4b75-4bf1-9b08-3e783b6a9d56", "940e0215-95b3-482f-ae65-5f744b72c23f", "Customer", "CUSTOMER" });
        }
    }
}
