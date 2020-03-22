using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PickupDay",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
