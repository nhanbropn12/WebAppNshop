using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshopsolution.Data.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

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
                name: "Comment",
                columns: table => new
                {
                    Idcomment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iduser = table.Column<int>(nullable: false),
                    feedback = table.Column<int>(nullable: false),
                    Datecreate = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Contentfeedback = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Idcomment);
                    table.ForeignKey(
                        name: "FK_Comment_Accounts_Iduser",
                        column: x => x.Iduser,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CardNumber", "DateCreate", "DateOfBirth", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Quy Nhon", "1234", new DateTime(2022, 5, 10, 9, 33, 42, 457, DateTimeKind.Local).AddTicks(5346), new DateTime(2022, 5, 10, 9, 33, 42, 456, DateTimeKind.Local).AddTicks(2794), "nguyentinh14032001@gmail.com", "NguyenTinh", "Nguyen" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Iduser",
                table: "Comment",
                column: "Iduser");

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
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
