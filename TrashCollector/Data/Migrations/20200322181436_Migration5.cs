using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "QueryDate",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "QueryDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int));

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
    }
}
