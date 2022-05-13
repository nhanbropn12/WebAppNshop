using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class removeTotalInOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 13, 17, 3, 11, 126, DateTimeKind.Local).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 13, 16, 24, 16, 101, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 13, 17, 3, 11, 131, DateTimeKind.Local).AddTicks(4678), new DateTime(2022, 5, 13, 17, 3, 11, 131, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "92f87501-445f-47af-b272-6ed2559a1c57");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfd7eade-8de9-415f-858e-3601733f4508", "AQAAAAEAACcQAAAAEEjQU7Jw/gDzzgUznrG09RaNwsgPmjQ9SireA1bp2Sx0ACTfEM3kAkXNRY++yR/1QQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 13, 16, 24, 16, 101, DateTimeKind.Local).AddTicks(1513),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 5, 13, 17, 3, 11, 126, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 24, 16, 106, DateTimeKind.Local).AddTicks(7083), new DateTime(2022, 5, 13, 16, 24, 16, 106, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "b11dd88f-3d93-429e-ae57-9f88300c53c7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44705bf0-2d60-4cff-807f-f58971e7cb1e", "AQAAAAEAACcQAAAAEJcgDJFL4IfnOVkdWAqz9gaMT3X1pzW+OYOBBqfL8NrWbR8DUS+z4ybyCWm2dYzHVg==" });
        }
    }
}
