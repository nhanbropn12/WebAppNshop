using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class modifyIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 23, 8, 32, 19, 731, DateTimeKind.Local).AddTicks(7798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 21, 15, 10, 56, 704, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 23, 8, 32, 19, 737, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 5, 23, 8, 32, 19, 737, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "64d1ac24-9052-4c91-865f-087125d2b338");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "CardNumber", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5343436453", "39cff596-fe78-4dde-a083-11fa29c2c2d5", "AQAAAAEAACcQAAAAEDmU/xH/oNLLFMBDti3ahm6SSQ9La9YHjK9XQXZe850rNY64OnbezMjNrFdgy0Nmpg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDay",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 21, 15, 10, 56, 704, DateTimeKind.Local).AddTicks(3588),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 5, 23, 8, 32, 19, 731, DateTimeKind.Local).AddTicks(7798));

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
                columns: new[] { "CardNumber", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "bd1814ac-6bad-4324-bb42-8ccf39720eb0", "AQAAAAEAACcQAAAAEErSjpCn+g5OHmaLipPjyanUvPoNXYiCVneKPGJvfjwtw4MWlInlC7qkgCiMFL48nQ==" });
        }
    }
}
