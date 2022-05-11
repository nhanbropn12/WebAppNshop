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
    [Migration("20220511140021_updateIdentity")]
    partial class updateIdentity
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
                            DateCreate = new DateTime(2022, 5, 11, 21, 0, 20, 700, DateTimeKind.Local).AddTicks(6294),
                            DateOfBirth = new DateTime(2022, 5, 11, 21, 0, 20, 699, DateTimeKind.Local).AddTicks(9205),
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
                            ConcurrencyStamp = "f3864ec2-0d90-4e4b-a1c3-0ea0099e3b55",
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
                            ConcurrencyStamp = "9cce493d-36d4-496c-afbb-1a86e59f6f0d",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979),
                            Email = "nguyenhuunhan1903@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nhân",
                            LastName = "Nguyễn",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEHuElxGi2Js48x1gksPunVoFrC7pJluqQ9cWmjaJ+rGt7srJATckD9c0jpThO2Kt6Q==",
                            PhoneNumber = "0985255602",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "nguyenhuunhan1903"
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
                            Warranty = 12
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
