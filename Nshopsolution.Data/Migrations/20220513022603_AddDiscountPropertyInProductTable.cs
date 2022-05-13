using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class AddDiscountPropertyInProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "discount",
                table: "Products",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 13, 9, 26, 3, 404, DateTimeKind.Local).AddTicks(8039), new DateTime(2022, 5, 13, 9, 26, 3, 403, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "10ac1659-90c9-486b-ad57-22a1c30f8ac1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a53349a5-9616-4ba5-8f2b-0117aea3289e", "AQAAAAEAACcQAAAAEDimn65/mr+5pFqmeLaj1fdBp/KVogY7Gbw0hwyGE89Vd+WrCVYC+lyTrpKOlH56KA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 12, 15, 52, 14, 394, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 5, 12, 15, 52, 14, 393, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                column: "ConcurrencyStamp",
                value: "699eb43f-db16-4abc-9d45-22d96a1eb382");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73a69d6b-d7fd-469b-82de-3e10921af8d6", "AQAAAAEAACcQAAAAEBR4M0/Q6bFievNX6PIEd40jXMpe0qijU0AXwafDwKQpXExeGLSW7XtQHNszVA/4DA==" });
        }
    }
}
