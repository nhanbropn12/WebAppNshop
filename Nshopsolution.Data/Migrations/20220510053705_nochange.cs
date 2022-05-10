using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class nochange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 5, 495, DateTimeKind.Local).AddTicks(9300), new DateTime(2022, 5, 10, 12, 37, 5, 495, DateTimeKind.Local).AddTicks(1140) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 10, 9, 33, 42, 457, DateTimeKind.Local).AddTicks(5346), new DateTime(2022, 5, 10, 9, 33, 42, 456, DateTimeKind.Local).AddTicks(2794) });
        }
    }
}
