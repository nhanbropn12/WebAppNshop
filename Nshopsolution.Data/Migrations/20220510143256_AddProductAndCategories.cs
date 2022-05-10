using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class AddProductAndCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 32, 55, 835, DateTimeKind.Local).AddTicks(8554), new DateTime(2022, 5, 10, 21, 32, 55, 835, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "IdCategory", "CategoryOfName" },
                values: new object[,]
                {
                    { "C1", "LapTop" },
                    { "C2", "PC" },
                    { "C3", "Bàn phím" },
                    { "C4", "Chuột" },
                    { "C5", "Màn hình" },
                    { "C6", "Tai nghe" },
                    { "C7", "Thiết bị mạng" },
                    { "C8", "Thiết bị văn phòng" },
                    { "C9", "Linh kiện PC" },
                    { "C10", "phụ kiện" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "idproduct", "IdCategory", "ImageProduct", "OriginalPrice", "ProductName", "Quantity", "Rating", "Specifications", "Warranty" },
                values: new object[] { new Guid("bfaec971-302a-4469-bea3-a11523cfd2a8"), "C1", "", 18000000m, "Laptop Dell Vostro 14 3405 V4R53500U001W ( 14\" Full HD / AMD Ryzen 5 3500U / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)", 10, 3, "CPU= AMD Ryzen 5 3500U;Màn hình=14WVA(1920 x 1080); RAM = 1 x 4GB DDR4 2400MHz; Đồ họa = AMD Radeon Vega 8 Graphics; Lưu trữ = 256GB SSD M.2 NVMe; Hệ điều hành = Windows 10 Home SL 64 - bit; Pin = 3 cell 42 Wh Pin liền; Khối lượng = 1.7 kg", 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C10");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "idproduct",
                keyValue: new Guid("bfaec971-302a-4469-bea3-a11523cfd2a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: "C1");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 10, 15, 19, 30, 892, DateTimeKind.Local).AddTicks(4999), new DateTime(2022, 5, 10, 15, 19, 30, 891, DateTimeKind.Local).AddTicks(7369) });
        }
    }
}
