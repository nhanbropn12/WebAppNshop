using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class AddDescriptionColumnInToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 14, 8, 7, 46, 905, DateTimeKind.Local).AddTicks(3292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 13, 17, 37, 21, 338, DateTimeKind.Local).AddTicks(8142));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6086778-141c-4251-8c29-60e8b5005280", "AQAAAAEAACcQAAAAEGEpUPnHyi45NhFXOAEF0XBIyvZ4UMX9c92ggmWRTuym3U+SDQiDK3q5SduXdB9Ubg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 13, 17, 37, 21, 338, DateTimeKind.Local).AddTicks(8142),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 5, 14, 8, 7, 46, 905, DateTimeKind.Local).AddTicks(3292));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7039be4-721e-4936-bc78-ac6849fc90ed", "AQAAAAEAACcQAAAAEJSHtxjY5xNIawUQaVFrwpWarhJw3FjrTeUAhDvocceVSpw0Xwang3OGaKBunfqjSA==" });
        }
    }
}
