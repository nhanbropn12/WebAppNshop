using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class Intial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategory = table.Column<string>(nullable: false),
                    CategoryOfName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    idproduct = table.Column<Guid>(nullable: false),
                    IdCategory = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Specifications = table.Column<string>(nullable: true),
                    ImageProduct = table.Column<string>(nullable: true),
                    Warranty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.idproduct);
                    table.ForeignKey(
                        name: "FK_Products_Categories_IdCategory",
                        column: x => x.IdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 9, 19, 3, 8, 850, DateTimeKind.Local).AddTicks(93), new DateTime(2022, 5, 9, 19, 3, 8, 848, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdCategory",
                table: "Products",
                column: "IdCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 7, 19, 57, 21, 316, DateTimeKind.Local).AddTicks(6799), new DateTime(2022, 5, 7, 19, 57, 21, 315, DateTimeKind.Local).AddTicks(5408) });
        }
    }
}
