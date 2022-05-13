using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class OrderAndOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CreateDay = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 5, 13, 16, 24, 16, 101, DateTimeKind.Local).AddTicks(1513)),
                    status = table.Column<int>(nullable: false, defaultValue: 3),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "idproduct",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "44705bf0-2d60-4cff-807f-f58971e7cb1e", "AQAAAAEAACcQAAAAEJcgDJFL4IfnOVkdWAqz9gaMT3X1pzW+OYOBBqfL8NrWbR8DUS+z4ybyCWm2dYzHVg==", "nguyenhuunhan1903@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "a53349a5-9616-4ba5-8f2b-0117aea3289e", "AQAAAAEAACcQAAAAEDimn65/mr+5pFqmeLaj1fdBp/KVogY7Gbw0hwyGE89Vd+WrCVYC+lyTrpKOlH56KA==", "nguyenhuunhan1903" });
        }
    }
}
