using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class updateIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 0, 20, 700, DateTimeKind.Local).AddTicks(6294), new DateTime(2022, 5, 11, 21, 0, 20, 699, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "f3864ec2-0d90-4e4b-a1c3-0ea0099e3b55");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9cce493d-36d4-496c-afbb-1a86e59f6f0d", "AQAAAAEAACcQAAAAEHuElxGi2Js48x1gksPunVoFrC7pJluqQ9cWmjaJ+rGt7srJATckD9c0jpThO2Kt6Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 11, 9, 40, 22, 395, DateTimeKind.Local).AddTicks(298), new DateTime(2022, 5, 11, 9, 40, 22, 394, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "055c4607-e376-44fe-a895-7f9833cd72b8");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bad976d7-a0ea-42ea-8dea-051bb300ccf6", "AQAAAAEAACcQAAAAEPsUikyNnP3lRO5kHf+jjBK9RceaO4Q/uKY2SGKvsi469pKFiitmjbrGejGaUqf5yA==" });
        }
    }
}
