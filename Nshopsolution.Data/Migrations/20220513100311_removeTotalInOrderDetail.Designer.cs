﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nshopsolution.Data.EF;

namespace Nshopsolution.Data.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20220513100311_removeTotalInOrderDetail")]
    partial class removeTotalInOrderDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                            RoleId = new Guid("7042c312-4894-454f-a631-b90edd2702f4")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Quy Nhon",
                            CardNumber = "1234",
                            DateCreate = new DateTime(2022, 5, 13, 17, 3, 11, 131, DateTimeKind.Local).AddTicks(4678),
                            DateOfBirth = new DateTime(2022, 5, 13, 17, 3, 11, 131, DateTimeKind.Local).AddTicks(4359),
                            Email = "nguyentinh14032001@gmail.com",
                            FirstName = "NguyenTinh",
                            LastName = "Nguyen"
                        });
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7042c312-4894-454f-a631-b90edd2702f4"),
                            ConcurrencyStamp = "92f87501-445f-47af-b272-6ed2559a1c57",
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c158b01-5aba-4469-bbb8-e55ea43126c6"),
                            AccessFailedCount = 0,
                            Address = "tổ 46 khu vực 9 phường Đống Đa Quy Nhơn",
                            ConcurrencyStamp = "bfd7eade-8de9-415f-858e-3601733f4508",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979),
                            Email = "nguyenhuunhan1903@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nhân",
                            LastName = "Nguyễn",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEEjQU7Jw/gDzzgUznrG09RaNwsgPmjQ9SireA1bp2Sx0ACTfEM3kAkXNRY++yR/1QQ==",
                            PhoneNumber = "0985255602",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "nguyenhuunhan1903@gmail.com"
                        });
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Category", b =>
                {
                    b.Property<string>("IdCategory")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryOfName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            IdCategory = "C1",
                            CategoryOfName = "LapTop"
                        },
                        new
                        {
                            IdCategory = "C2",
                            CategoryOfName = "PC"
                        },
                        new
                        {
                            IdCategory = "C3",
                            CategoryOfName = "Bàn phím"
                        },
                        new
                        {
                            IdCategory = "C4",
                            CategoryOfName = "Chuột"
                        },
                        new
                        {
                            IdCategory = "C5",
                            CategoryOfName = "Màn hình"
                        },
                        new
                        {
                            IdCategory = "C6",
                            CategoryOfName = "Tai nghe"
                        },
                        new
                        {
                            IdCategory = "C7",
                            CategoryOfName = "Thiết bị mạng"
                        },
                        new
                        {
                            IdCategory = "C8",
                            CategoryOfName = "Thiết bị văn phòng"
                        },
                        new
                        {
                            IdCategory = "C9",
                            CategoryOfName = "Linh kiện PC"
                        },
                        new
                        {
                            IdCategory = "C10",
                            CategoryOfName = "phụ kiện"
                        });
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Comment", b =>
                {
                    b.Property<int>("Idcomment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contentfeedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datecreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Iduser")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("feedback")
                        .HasColumnType("int");

                    b.HasKey("Idcomment");

                    b.HasIndex("Iduser");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 5, 13, 17, 3, 11, 126, DateTimeKind.Local).AddTicks(5119));

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(3);

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("idproduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdCategory")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<int>("discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(50)
                        .HasDefaultValue(0);

                    b.HasKey("idproduct");

                    b.HasIndex("IdCategory");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            idproduct = new Guid("bfaec971-302a-4469-bea3-a11523cfd2a8"),
                            IdCategory = "C1",
                            ImageProduct = "",
                            OriginalPrice = 18000000m,
                            ProductName = "Laptop Dell Vostro 14 3405 V4R53500U001W ( 14\" Full HD / AMD Ryzen 5 3500U / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)",
                            Quantity = 10,
                            Rating = 3,
                            Specifications = "CPU= AMD Ryzen 5 3500U;Màn hình=14WVA(1920 x 1080); RAM = 1 x 4GB DDR4 2400MHz; Đồ họa = AMD Radeon Vega 8 Graphics; Lưu trữ = 256GB SSD M.2 NVMe; Hệ điều hành = Windows 10 Home SL 64 - bit; Pin = 3 cell 42 Wh Pin liền; Khối lượng = 1.7 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("c3d51b17-96c0-40e6-a57b-5f2bc5f782b9"),
                            IdCategory = "C1",
                            ImageProduct = "https://lh3.googleusercontent.com/eSTPgChkodGi0H_f0Qp6bvPGDejkhMJTvpmNR-doH0qdNBrFXGcbft7N_BJxoKcfoZ_r1U8M9CcX-Ms9Yw=w1000-rw",
                            OriginalPrice = 19500000m,
                            ProductName = "Laptop Acer Spin 5 SP513-52N-556V (NX.GR7SV.004) (13.3 FHD / i5 - 8250U / 8GB / UHD 620 / Win10 / 1.5 kg)",
                            Quantity = 10,
                            Rating = 3,
                            Specifications = "CPU= Intel Core i5-8250U ( 1.6 GHz - 3.4 GHz / 6MB / 4 nhân, 8 luồng );Màn hình= 13.3 IPS ( 1920 x 1080 ) ; cảm ứngRAM = 8GB Onboard DDR4 2400MHz ; Đồ họa =  Intel UHD Graphics 620 Lưu trữ: 256GB SSD M.2 SATA; Hệ điều hành = Windows 10 Home SL 64 - bitPin = 3 cell 53 Wh ; Pin liền =  khối lượng: 1.5 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("88846fc1-0b57-4089-94c9-55b4bd87b01a"),
                            IdCategory = "C1",
                            ImageProduct = "https://lh3.googleusercontent.com/bhtZjMnawGGNgtOjAc-_pgG6VKN1pXwb16dlPkME6oVd03EU04c3MPMYRWnKP0bM8AuYgOn7gMysClWnTxJC8X8ho4-UtSaq=w500-rw",
                            OriginalPrice = 21000000m,
                            ProductName = "Laptop Dell Inspiron 15 3511 P112F001ABL ( 15.6 Intel Core i3 - 1115G4 / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)",
                            Quantity = 3,
                            Rating = 4,
                            Specifications = "- CPU: Intel Core i3-1115G4 ;Màn hình: 15.6 WVA (1920 x 1080);RAM: 1 x 4GB DDR4 2666MHz;Đồ họa: Intel UHD Graphics;Lưu trữ: 256GB SSD M.2 NVMe /;Hệ điều hành: Windows 10 Home SL 64 - bit;Pin: 3 cell 41 Wh Pin liền;Khối lượng: 1.7 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("41fb912b-349c-43dd-8b9a-e1599bf55de3"),
                            IdCategory = "C1",
                            ImageProduct = "https://lh3.googleusercontent.com/3D8Bt27a8BymWuIkYbcCRp9TirvD4rj0x8w9UAgrjAmhaV2PP4rTCSN_h5P6m6KZaGohFNyjvFv9wUwKyfBl3Rjbcio8pdWmew=w500-rw",
                            OriginalPrice = 27990000m,
                            ProductName = "Laptop GIGABYTE G5 KC G5 KC-5S11130SB ( 15.6 Full HD / 144Hz / Intel Core i5 - 10500H / 16GB / 512GB SSD / NVIDIA GeForce RTX 3060 / Windows 11 Home SL / 2.2kg)",
                            Quantity = 3,
                            Rating = 4,
                            Specifications = "CPU: Intel Core i5-10500H;Màn hình: 15.6;IPS(1920 x 1080), 144HzRAM: 2 x 8GB DDR4 3200MHz;Đồ họa: NVIDIA GeForce RTX 3060 6GB GDDR6 / Intel UHD Graphics;Lưu trữ: 512GB SSD M.2 NVMe /;Hệ điều hành: Windows 11 Home SL; 49 Wh Pin rời;Khối lượng: 2.2 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("50c3753f-af27-4cb2-9ee9-3578df8da398"),
                            IdCategory = "C1",
                            ImageProduct = "https://lh3.googleusercontent.com/uSGjbg8VUgeVtz_MAnRx9Xuz-HSkroMYposJU1DcHndsqssZ8waaissoaZZU6qOsC7Iv3DGJ7FRwMLmokk725y0OV3jxGShd=w500-rw",
                            OriginalPrice = 18290000m,
                            ProductName = "Laptop HP 15s-fq2558TU 46M26PA ( 15.6 HD / Intel Core i7 - 1165G7 / 8GB / 512GB SSD / Windows 11 Home / 1.7kg)",
                            Quantity = 3,
                            Rating = 2,
                            Specifications = "- CPU: Intel Core i7-1165G7;Màn hình: 15.6 IPS (1366 x 768);RAM: 2 x 4GB DDR4 3200MHz;Đồ họa: Intel Iris Xe Graphics;Lưu trữ: 512GB SSD M.2 NVMe /;Hệ điều hành: Windows 11 Home;Pin: 3 cell 41 Wh Pin liền;Khối lượng: 1.7 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("0b4caca7-8146-4b48-84d5-8a1eeb51f0db"),
                            IdCategory = "C1",
                            ImageProduct = "https://lh3.googleusercontent.com/H748rHBN_hG0Mi8Fbx0bWQJTef7EATgL4nNhM55UoxzdEg8gZL5Uv0BFpd2iyyXJpmmtnZuFwgsusXjYdtzdt5f44yvF9JZN=w500-rw",
                            OriginalPrice = 24490000m,
                            ProductName = "Laptop APPLE MacBook Air 2020 MGN93SA/A ( 13.3 Apple M1 / 8GB / 256GB SSD / macOS / 1.3kg)",
                            Quantity = 3,
                            Rating = 4,
                            Specifications = "- CPU: Apple M1;Màn hình: 13.3 IPS (2560 x 1600);RAM: 8GB Onboard LPDDR4 3733MHz; Đồ họa:;Lưu trữ: 256GB SSD /;Hệ điều hành: macOS;Pin liền;Khối lượng: 1.3 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("1ab2a6ea-e550-48f2-9226-cf4837ed564b"),
                            IdCategory = "C4",
                            ImageProduct = "https://lh3.googleusercontent.com/ybmilqnSaF4zHCtDYeUGxQM3ZMPJf9YDyJeUN4vS-J20qOcvbgsg3foBZ5rbQ_XU7ihvsfVqxEvY3nHqhpM=w500-rw",
                            OriginalPrice = 889000m,
                            ProductName = "Chuột máy tính gaming Logitech G Pro Hero (910-005442) (Đen)",
                            Quantity = 3,
                            Rating = 4,
                            Specifications = "Cảm biến hero 16K chính xác ;Trọng lượng 83g;Cảm biến HERO 16K;6 nút có thể lập trình theo sở thích với Logitech HUB G;Lightsync RGB LED;5 cấu hình bộ nhớ tích hợp ",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("b4f73dcf-c2ec-4560-a05a-5d92628d7814"),
                            IdCategory = "C4",
                            ImageProduct = "https://lh3.googleusercontent.com/0-E5Fo9SKhAFknEetUN64y0NcMuZ4ciM5tgTN0KoU1Z5Vc_5HPvVGcF34vVVtBrdUYOOOKFdZ6m6zQ5xXoE=w500-rw",
                            OriginalPrice = 2549000m,
                            ProductName = "Chuột máy tính Logitech G Pro Wireless Gaming (Đen)",
                            Quantity = 3,
                            Rating = 4,
                            Specifications = "- CPU: Apple M1;Màn hình: 13.3 IPS (2560 x 1600);RAM: 8GB Onboard LPDDR4 3733MHz; Đồ họa:;Lưu trữ: 256GB SSD /;Hệ điều hành: macOS;Pin liền;Khối lượng: 1.3 kg",
                            Warranty = 12,
                            discount = 0
                        },
                        new
                        {
                            idproduct = new Guid("dc873c87-26f8-408a-ac82-d1d36b3af7ec"),
                            IdCategory = "C2",
                            ImageProduct = "https://img1.phongvu.vn/media/catalog/product/1/_/1_38_31.jpg",
                            OriginalPrice = 11590000m,
                            ProductName = "Máy tính để bàn - PC Acer AS XC-885 DT.BAQSV.010 (i5-8400/4GB/1TB HDD/GT 730/Win10)",
                            Quantity = 3,
                            Rating = 4,
                            Specifications = "CPU: Intel Core i5-8400 ( 2.8 GHz - 4.0 GHz / 9MB / 6 nhân, 6 luồng );RAM: 1 x 4GB DDR4 2666MHz;Đồ họa: Intel UHD Graphics 630 / GeForce GT 730 2GB;Lưu trữ: 1TB HDD 7200RPM;Tặng kèm chuột; bàn phím",
                            Warranty = 12,
                            discount = 0
                        });
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Comment", b =>
                {
                    b.HasOne("Nshopsolution.Data.Entities.Account", "Account")
                        .WithMany("Comments")
                        .HasForeignKey("Iduser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Order", b =>
                {
                    b.HasOne("Nshopsolution.Data.Entities.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("Nshopsolution.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nshopsolution.Data.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nshopsolution.Data.Entities.Product", b =>
                {
                    b.HasOne("Nshopsolution.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("IdCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
