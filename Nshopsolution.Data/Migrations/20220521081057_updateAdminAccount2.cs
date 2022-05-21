using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class updateAdminAccount2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 21, 15, 10, 56, 704, DateTimeKind.Local).AddTicks(3588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 21, 15, 9, 3, 983, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 21, 15, 10, 56, 709, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 5, 21, 15, 10, 56, 709, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "873b03d3-513e-47c2-b50a-087a88656d2f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd1814ac-6bad-4324-bb42-8ccf39720eb0", "AQAAAAEAACcQAAAAEErSjpCn+g5OHmaLipPjyanUvPoNXYiCVneKPGJvfjwtw4MWlInlC7qkgCiMFL48nQ==", "1820fce4-b5dd-4d69-aaca-d8e31dab6dd9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 21, 15, 9, 3, 983, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 5, 21, 15, 10, 56, 704, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 21, 15, 9, 3, 989, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 5, 21, 15, 9, 3, 988, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "5f7cee75-4bb9-415f-ae08-8e1ec8b93049");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b35af17-b736-4d76-accb-963b7a2f2d40", "AQAAAAEAACcQAAAAELCVldWiYNUkE3pJL1+etb6qz3PvCEDWyHVjjRRX9RwkJPyJYxvBNou3BhuT6+CUMA==", "00000000-0000-0000-0000-000000000000" });
        }
    }
}
