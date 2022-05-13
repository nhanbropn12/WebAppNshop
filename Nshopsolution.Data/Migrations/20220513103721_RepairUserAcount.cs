using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class RepairUserAcount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 13, 17, 37, 21, 338, DateTimeKind.Local).AddTicks(8142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 13, 17, 3, 11, 126, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 13, 17, 37, 21, 343, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 5, 13, 17, 37, 21, 343, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "f8608a42-1a81-4f10-b670-3a182f44d3bb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "a7039be4-721e-4936-bc78-ac6849fc90ed", "NGUYENHUUNHAN1903@GMAIL.COM", "NGUYENHUUNHAN1903@GMAIL.COM", "AQAAAAEAACcQAAAAEJSHtxjY5xNIawUQaVFrwpWarhJw3FjrTeUAhDvocceVSpw0Xwang3OGaKBunfqjSA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 13, 17, 3, 11, 126, DateTimeKind.Local).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 5, 13, 17, 37, 21, 338, DateTimeKind.Local).AddTicks(8142));

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "bfd7eade-8de9-415f-858e-3601733f4508", null, null, "AQAAAAEAACcQAAAAEEjQU7Jw/gDzzgUznrG09RaNwsgPmjQ9SireA1bp2Sx0ACTfEM3kAkXNRY++yR/1QQ==" });
        }
    }
}
