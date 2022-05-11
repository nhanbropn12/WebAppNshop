using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class CreateAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 11, 9, 40, 22, 395, DateTimeKind.Local).AddTicks(298), new DateTime(2022, 5, 11, 9, 40, 22, 394, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7042c312-4894-454f-a631-b90edd2702f4"), "055c4607-e376-44fe-a895-7f9833cd72b8", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CardNumber", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"), 0, "tổ 46 khu vực 9 phường Đống Đa Quy Nhơn", null, "bad976d7-a0ea-42ea-8dea-051bb300ccf6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), "nguyenhuunhan1903@gmail.com", false, "Nhân", "Nguyễn", false, null, null, null, "AQAAAAEAACcQAAAAEPsUikyNnP3lRO5kHf+jjBK9RceaO4Q/uKY2SGKvsi469pKFiitmjbrGejGaUqf5yA==", "0985255602", false, "", false, "nguyenhuunhan1903" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"), new Guid("7042c312-4894-454f-a631-b90edd2702f4") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7042c312-4894-454f-a631-b90edd2702f4"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"), new Guid("7042c312-4894-454f-a631-b90edd2702f4") });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 32, 55, 835, DateTimeKind.Local).AddTicks(8554), new DateTime(2022, 5, 10, 21, 32, 55, 835, DateTimeKind.Local).AddTicks(794) });
        }
    }
}
