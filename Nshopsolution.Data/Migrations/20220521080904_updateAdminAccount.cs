using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class updateAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 21, 15, 9, 3, 983, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 14, 8, 7, 46, 905, DateTimeKind.Local).AddTicks(3292));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 14, 8, 7, 46, 905, DateTimeKind.Local).AddTicks(3292),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 5, 21, 15, 9, 3, 983, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 14, 8, 7, 46, 910, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 5, 14, 8, 7, 46, 910, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "da3269f9-9369-4480-92cb-db7a37397260");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6086778-141c-4251-8c29-60e8b5005280", "AQAAAAEAACcQAAAAEGEpUPnHyi45NhFXOAEF0XBIyvZ4UMX9c92ggmWRTuym3U+SDQiDK3q5SduXdB9Ubg==", "" });
        }
    }
}
