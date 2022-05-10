﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nshopsolution.Data.EF;

namespace Nshopsolution.Data.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    partial class EShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            DateCreate = new DateTime(2022, 5, 10, 9, 33, 42, 457, DateTimeKind.Local).AddTicks(5346),
                            DateOfBirth = new DateTime(2022, 5, 10, 9, 33, 42, 456, DateTimeKind.Local).AddTicks(2794),
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

            modelBuilder.Entity("Nshopsolution.Data.Entities.Category", b =>
                {
                    b.Property<string>("IdCategory")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryOfName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");
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
