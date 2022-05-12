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
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
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
                values: new object[] { 1, "Quy Nhon", "1234", new DateTime(2022, 5, 12, 15, 52, 14, 394, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 5, 12, 15, 52, 14, 393, DateTimeKind.Local).AddTicks(5204), "nguyentinh14032001@gmail.com", "NguyenTinh", "Nguyen" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7042c312-4894-454f-a631-b90edd2702f4"), "699eb43f-db16-4abc-9d45-22d96a1eb382", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"), new Guid("7042c312-4894-454f-a631-b90edd2702f4") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CardNumber", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"), 0, "tổ 46 khu vực 9 phường Đống Đa Quy Nhơn", null, "73a69d6b-d7fd-469b-82de-3e10921af8d6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), "nguyenhuunhan1903@gmail.com", false, "Nhân", "Nguyễn", false, null, null, null, "AQAAAAEAACcQAAAAEBR4M0/Q6bFievNX6PIEd40jXMpe0qijU0AXwafDwKQpXExeGLSW7XtQHNszVA/4DA==", "0985255602", false, "", false, "nguyenhuunhan1903" });

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
                values: new object[,]
                {
                    { new Guid("bfaec971-302a-4469-bea3-a11523cfd2a8"), "C1", "", 18000000m, "Laptop Dell Vostro 14 3405 V4R53500U001W ( 14\" Full HD / AMD Ryzen 5 3500U / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)", 10, 3, "CPU= AMD Ryzen 5 3500U;Màn hình=14WVA(1920 x 1080); RAM = 1 x 4GB DDR4 2400MHz; Đồ họa = AMD Radeon Vega 8 Graphics; Lưu trữ = 256GB SSD M.2 NVMe; Hệ điều hành = Windows 10 Home SL 64 - bit; Pin = 3 cell 42 Wh Pin liền; Khối lượng = 1.7 kg", 12 },
                    { new Guid("c3d51b17-96c0-40e6-a57b-5f2bc5f782b9"), "C1", "https://lh3.googleusercontent.com/eSTPgChkodGi0H_f0Qp6bvPGDejkhMJTvpmNR-doH0qdNBrFXGcbft7N_BJxoKcfoZ_r1U8M9CcX-Ms9Yw=w1000-rw", 19500000m, "Laptop Acer Spin 5 SP513-52N-556V (NX.GR7SV.004) (13.3 FHD / i5 - 8250U / 8GB / UHD 620 / Win10 / 1.5 kg)", 10, 3, "CPU= Intel Core i5-8250U ( 1.6 GHz - 3.4 GHz / 6MB / 4 nhân, 8 luồng );Màn hình= 13.3 IPS ( 1920 x 1080 ) ; cảm ứngRAM = 8GB Onboard DDR4 2400MHz ; Đồ họa =  Intel UHD Graphics 620 Lưu trữ: 256GB SSD M.2 SATA; Hệ điều hành = Windows 10 Home SL 64 - bitPin = 3 cell 53 Wh ; Pin liền =  khối lượng: 1.5 kg", 12 },
                    { new Guid("88846fc1-0b57-4089-94c9-55b4bd87b01a"), "C1", "https://lh3.googleusercontent.com/bhtZjMnawGGNgtOjAc-_pgG6VKN1pXwb16dlPkME6oVd03EU04c3MPMYRWnKP0bM8AuYgOn7gMysClWnTxJC8X8ho4-UtSaq=w500-rw", 21000000m, "Laptop Dell Inspiron 15 3511 P112F001ABL ( 15.6 Intel Core i3 - 1115G4 / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)", 3, 4, "- CPU: Intel Core i3-1115G4 ;Màn hình: 15.6 WVA (1920 x 1080);RAM: 1 x 4GB DDR4 2666MHz;Đồ họa: Intel UHD Graphics;Lưu trữ: 256GB SSD M.2 NVMe /;Hệ điều hành: Windows 10 Home SL 64 - bit;Pin: 3 cell 41 Wh Pin liền;Khối lượng: 1.7 kg", 12 },
                    { new Guid("41fb912b-349c-43dd-8b9a-e1599bf55de3"), "C1", "https://lh3.googleusercontent.com/3D8Bt27a8BymWuIkYbcCRp9TirvD4rj0x8w9UAgrjAmhaV2PP4rTCSN_h5P6m6KZaGohFNyjvFv9wUwKyfBl3Rjbcio8pdWmew=w500-rw", 27990000m, "Laptop GIGABYTE G5 KC G5 KC-5S11130SB ( 15.6 Full HD / 144Hz / Intel Core i5 - 10500H / 16GB / 512GB SSD / NVIDIA GeForce RTX 3060 / Windows 11 Home SL / 2.2kg)", 3, 4, "CPU: Intel Core i5-10500H;Màn hình: 15.6;IPS(1920 x 1080), 144HzRAM: 2 x 8GB DDR4 3200MHz;Đồ họa: NVIDIA GeForce RTX 3060 6GB GDDR6 / Intel UHD Graphics;Lưu trữ: 512GB SSD M.2 NVMe /;Hệ điều hành: Windows 11 Home SL; 49 Wh Pin rời;Khối lượng: 2.2 kg", 12 },
                    { new Guid("50c3753f-af27-4cb2-9ee9-3578df8da398"), "C1", "https://lh3.googleusercontent.com/uSGjbg8VUgeVtz_MAnRx9Xuz-HSkroMYposJU1DcHndsqssZ8waaissoaZZU6qOsC7Iv3DGJ7FRwMLmokk725y0OV3jxGShd=w500-rw", 18290000m, "Laptop HP 15s-fq2558TU 46M26PA ( 15.6 HD / Intel Core i7 - 1165G7 / 8GB / 512GB SSD / Windows 11 Home / 1.7kg)", 3, 2, "- CPU: Intel Core i7-1165G7;Màn hình: 15.6 IPS (1366 x 768);RAM: 2 x 4GB DDR4 3200MHz;Đồ họa: Intel Iris Xe Graphics;Lưu trữ: 512GB SSD M.2 NVMe /;Hệ điều hành: Windows 11 Home;Pin: 3 cell 41 Wh Pin liền;Khối lượng: 1.7 kg", 12 },
                    { new Guid("0b4caca7-8146-4b48-84d5-8a1eeb51f0db"), "C1", "https://lh3.googleusercontent.com/H748rHBN_hG0Mi8Fbx0bWQJTef7EATgL4nNhM55UoxzdEg8gZL5Uv0BFpd2iyyXJpmmtnZuFwgsusXjYdtzdt5f44yvF9JZN=w500-rw", 24490000m, "Laptop APPLE MacBook Air 2020 MGN93SA/A ( 13.3 Apple M1 / 8GB / 256GB SSD / macOS / 1.3kg)", 3, 4, "- CPU: Apple M1;Màn hình: 13.3 IPS (2560 x 1600);RAM: 8GB Onboard LPDDR4 3733MHz; Đồ họa:;Lưu trữ: 256GB SSD /;Hệ điều hành: macOS;Pin liền;Khối lượng: 1.3 kg", 12 },
                    { new Guid("dc873c87-26f8-408a-ac82-d1d36b3af7ec"), "C2", "https://img1.phongvu.vn/media/catalog/product/1/_/1_38_31.jpg", 11590000m, "Máy tính để bàn - PC Acer AS XC-885 DT.BAQSV.010 (i5-8400/4GB/1TB HDD/GT 730/Win10)", 3, 4, "CPU: Intel Core i5-8400 ( 2.8 GHz - 4.0 GHz / 9MB / 6 nhân, 6 luồng );RAM: 1 x 4GB DDR4 2666MHz;Đồ họa: Intel UHD Graphics 630 / GeForce GT 730 2GB;Lưu trữ: 1TB HDD 7200RPM;Tặng kèm chuột; bàn phím", 12 },
                    { new Guid("1ab2a6ea-e550-48f2-9226-cf4837ed564b"), "C4", "https://lh3.googleusercontent.com/ybmilqnSaF4zHCtDYeUGxQM3ZMPJf9YDyJeUN4vS-J20qOcvbgsg3foBZ5rbQ_XU7ihvsfVqxEvY3nHqhpM=w500-rw", 889000m, "Chuột máy tính gaming Logitech G Pro Hero (910-005442) (Đen)", 3, 4, "Cảm biến hero 16K chính xác ;Trọng lượng 83g;Cảm biến HERO 16K;6 nút có thể lập trình theo sở thích với Logitech HUB G;Lightsync RGB LED;5 cấu hình bộ nhớ tích hợp ", 12 },
                    { new Guid("b4f73dcf-c2ec-4560-a05a-5d92628d7814"), "C4", "https://lh3.googleusercontent.com/0-E5Fo9SKhAFknEetUN64y0NcMuZ4ciM5tgTN0KoU1Z5Vc_5HPvVGcF34vVVtBrdUYOOOKFdZ6m6zQ5xXoE=w500-rw", 2549000m, "Chuột máy tính Logitech G Pro Wireless Gaming (Đen)", 3, 4, "- CPU: Apple M1;Màn hình: 13.3 IPS (2560 x 1600);RAM: 8GB Onboard LPDDR4 3733MHz; Đồ họa:;Lưu trữ: 256GB SSD /;Hệ điều hành: macOS;Pin liền;Khối lượng: 1.3 kg", 12 }
                });

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
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

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
