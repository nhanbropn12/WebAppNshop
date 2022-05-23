using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Extention
{
  public static  class ModelBuilderExtentions
    {
      public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new Account() { Id=1,LastName="Nguyen",FirstName="NguyenTinh",Email="nguyentinh14032001@gmail.com",Address="Quy Nhon",CardNumber="1234",DateOfBirth=DateTime.Now,DateCreate=DateTime.Now}
                );


            Guid IdRoleAdmin = new Guid("7042C312-4894-454F-A631-B90EDD2702F4");
            Guid IdUserAdmin = new Guid("7C158B01-5ABA-4469-BBB8-E55EA43126C6");
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = IdRoleAdmin,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { Id=IdUserAdmin,FirstName="Nhân",LastName="Nguyễn",
                UserName= "nguyenhuunhan1903@gmail.com",
                    Email="nguyenhuunhan1903@gmail.com",
                    PhoneNumber="0985255602",DateOfBirth=new DateTime(2001-03-19),
                    PasswordHash = hasher.HashPassword(null, "@Rhymastic"),
                    SecurityStamp = new Guid("1820FCE4-B5DD-4D69-AACA-D8E31DAB6DD9").ToString("D"),
                    NormalizedEmail="NGUYENHUUNHAN1903@GMAIL.COM",
                    NormalizedUserName= "NGUYENHUUNHAN1903@GMAIL.COM",
                    Address ="tổ 46 khu vực 9 phường Đống Đa Quy Nhơn",
                    CardNumber="5343436453"
                 

                }
                );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = IdRoleAdmin,
                UserId = IdUserAdmin
            });
            modelBuilder.Entity<Category>().HasData(
                    new Category { IdCategory = "C1", CategoryOfName = "LapTop" },
                    new Category { IdCategory = "C2", CategoryOfName = "PC" },
                    new Category { IdCategory = "C3", CategoryOfName = "Bàn phím" },
                    new Category { IdCategory = "C4", CategoryOfName = "Chuột" },
                    new Category { IdCategory = "C5", CategoryOfName = "Màn hình" },
                    new Category { IdCategory = "C6", CategoryOfName = "Tai nghe" },
                    new Category { IdCategory = "C7", CategoryOfName = "Thiết bị mạng" },
                    new Category { IdCategory = "C8", CategoryOfName = "Thiết bị văn phòng" },
                    new Category { IdCategory = "C9", CategoryOfName = "Linh kiện PC" },
                    new Category { IdCategory = "C10", CategoryOfName = "phụ kiện" }
                    );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    idproduct = new Guid("BFAEC971-302A-4469-BEA3-A11523CFD2A8"),
                    IdCategory = "C1",
                    ProductName = "Laptop Dell Vostro 14 3405 V4R53500U001W ( 14\" Full HD / AMD Ryzen 5 3500U / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)",
                    ImageProduct = "",
                    OriginalPrice = 18000000,
                    Specifications = "CPU= AMD Ryzen 5 3500U;Màn hình=14WVA(1920 x 1080); RAM = 1 x 4GB DDR4 2400MHz; Đồ họa = AMD Radeon Vega 8 Graphics; Lưu trữ = 256GB SSD M.2 NVMe; Hệ điều hành = Windows 10 Home SL 64 - bit; Pin = 3 cell 42 Wh Pin liền; Khối lượng = 1.7 kg",
                    Warranty = 12,
                    Quantity = 10,
                    Rating = Enum.Rate.fourStar
                },
                new Product
                {
                    idproduct = new Guid("C3D51B17-96C0-40E6-A57B-5F2BC5F782B9"),
                    IdCategory = "C1",
                    ProductName = "Laptop Acer Spin 5 SP513-52N-556V (NX.GR7SV.004) (13.3 FHD / i5 - 8250U / 8GB / UHD 620 / Win10 / 1.5 kg)",
                    ImageProduct = "https://lh3.googleusercontent.com/eSTPgChkodGi0H_f0Qp6bvPGDejkhMJTvpmNR-doH0qdNBrFXGcbft7N_BJxoKcfoZ_r1U8M9CcX-Ms9Yw=w1000-rw",
                    OriginalPrice = 19500000,
                    Specifications = "CPU= Intel Core i5-8250U ( 1.6 GHz - 3.4 GHz / 6MB / 4 nhân, 8 luồng );Màn hình= 13.3 IPS ( 1920 x 1080 ) ; cảm ứngRAM = 8GB Onboard DDR4 2400MHz ; Đồ họa =  Intel UHD Graphics 620 Lưu trữ: 256GB SSD M.2 SATA; Hệ điều hành = Windows 10 Home SL 64 - bitPin = 3 cell 53 Wh ; Pin liền =  khối lượng: 1.5 kg",
                    Warranty = 12,
                    Quantity = 10,
                    Rating = Enum.Rate.fourStar
                },
                new Product
                {
                    idproduct = new Guid("88846FC1-0B57-4089-94C9-55B4BD87B01A"),
                    IdCategory = "C1",
                    ProductName = "Laptop Dell Inspiron 15 3511 P112F001ABL ( 15.6 Intel Core i3 - 1115G4 / 4GB / 256GB SSD / Windows 10 Home SL 64 - bit / 1.7kg)",
                    ImageProduct = "https://lh3.googleusercontent.com/bhtZjMnawGGNgtOjAc-_pgG6VKN1pXwb16dlPkME6oVd03EU04c3MPMYRWnKP0bM8AuYgOn7gMysClWnTxJC8X8ho4-UtSaq=w500-rw",
                    OriginalPrice = 21000000,
                    Specifications = "- CPU: Intel Core i3-1115G4 ;Màn hình: 15.6 WVA (1920 x 1080);RAM: 1 x 4GB DDR4 2666MHz;Đồ họa: Intel UHD Graphics;Lưu trữ: 256GB SSD M.2 NVMe /;Hệ điều hành: Windows 10 Home SL 64 - bit;Pin: 3 cell 41 Wh Pin liền;Khối lượng: 1.7 kg",
                    Warranty = 12,
                    Quantity = 3,
                    Rating = Enum.Rate.fiveStar
                },

                new Product
                {
                    idproduct = new Guid("41FB912B-349C-43DD-8B9A-E1599BF55DE3"),
                    IdCategory = "C1",
                    ProductName = "Laptop GIGABYTE G5 KC G5 KC-5S11130SB ( 15.6 Full HD / 144Hz / Intel Core i5 - 10500H / 16GB / 512GB SSD / NVIDIA GeForce RTX 3060 / Windows 11 Home SL / 2.2kg)",
                    ImageProduct = "https://lh3.googleusercontent.com/3D8Bt27a8BymWuIkYbcCRp9TirvD4rj0x8w9UAgrjAmhaV2PP4rTCSN_h5P6m6KZaGohFNyjvFv9wUwKyfBl3Rjbcio8pdWmew=w500-rw",
                    OriginalPrice = 27990000,
                    Specifications = "CPU: Intel Core i5-10500H;Màn hình: 15.6;IPS(1920 x 1080), 144HzRAM: 2 x 8GB DDR4 3200MHz;Đồ họa: NVIDIA GeForce RTX 3060 6GB GDDR6 / Intel UHD Graphics;Lưu trữ: 512GB SSD M.2 NVMe /;Hệ điều hành: Windows 11 Home SL; 49 Wh Pin rời;Khối lượng: 2.2 kg",
                    Warranty = 12,
                    Quantity = 3,
                    Rating = Enum.Rate.fiveStar
                },
                new Product
                {
                    idproduct = new Guid("50C3753F-AF27-4CB2-9EE9-3578DF8DA398"),
                    IdCategory = "C1",
                    ProductName = "Laptop HP 15s-fq2558TU 46M26PA ( 15.6 HD / Intel Core i7 - 1165G7 / 8GB / 512GB SSD / Windows 11 Home / 1.7kg)",
                    ImageProduct = "https://lh3.googleusercontent.com/uSGjbg8VUgeVtz_MAnRx9Xuz-HSkroMYposJU1DcHndsqssZ8waaissoaZZU6qOsC7Iv3DGJ7FRwMLmokk725y0OV3jxGShd=w500-rw",
                    OriginalPrice = 18290000,
                    Specifications = "- CPU: Intel Core i7-1165G7;Màn hình: 15.6 IPS (1366 x 768);RAM: 2 x 4GB DDR4 3200MHz;Đồ họa: Intel Iris Xe Graphics;Lưu trữ: 512GB SSD M.2 NVMe /;Hệ điều hành: Windows 11 Home;Pin: 3 cell 41 Wh Pin liền;Khối lượng: 1.7 kg",
                    Warranty = 12,
                    Quantity = 3,
                    Rating = Enum.Rate.threeStar
                },
                new Product
                {
                    idproduct = new Guid("0B4CACA7-8146-4B48-84D5-8A1EEB51F0DB"),
                    IdCategory = "C1",
                    ProductName = "Laptop APPLE MacBook Air 2020 MGN93SA/A ( 13.3 Apple M1 / 8GB / 256GB SSD / macOS / 1.3kg)",
                    ImageProduct = "https://lh3.googleusercontent.com/H748rHBN_hG0Mi8Fbx0bWQJTef7EATgL4nNhM55UoxzdEg8gZL5Uv0BFpd2iyyXJpmmtnZuFwgsusXjYdtzdt5f44yvF9JZN=w500-rw",
                    OriginalPrice = 24490000,
                    Specifications = "- CPU: Apple M1;Màn hình: 13.3 IPS (2560 x 1600);RAM: 8GB Onboard LPDDR4 3733MHz; Đồ họa:;Lưu trữ: 256GB SSD /;Hệ điều hành: macOS;Pin liền;Khối lượng: 1.3 kg",
                    Warranty = 12,
                    Quantity = 3,
                    Rating = Enum.Rate.fiveStar
                },
                 new Product
                 {
                     idproduct = new Guid("1AB2A6EA-E550-48F2-9226-CF4837ED564B"),
                     IdCategory = "C4",
                     ProductName = "Chuột máy tính gaming Logitech G Pro Hero (910-005442) (Đen)",
                     ImageProduct = "https://lh3.googleusercontent.com/ybmilqnSaF4zHCtDYeUGxQM3ZMPJf9YDyJeUN4vS-J20qOcvbgsg3foBZ5rbQ_XU7ihvsfVqxEvY3nHqhpM=w500-rw",
                     OriginalPrice = 889000,
                     Specifications = "Cảm biến hero 16K chính xác ;Trọng lượng 83g;Cảm biến HERO 16K;6 nút có thể lập trình theo sở thích với Logitech HUB G;Lightsync RGB LED;5 cấu hình bộ nhớ tích hợp ",
                     Warranty = 12,
                     Quantity = 3,
                     Rating = Enum.Rate.fiveStar
                 },
                  new Product
                  {
                      idproduct = new Guid("B4F73DCF-C2EC-4560-A05A-5D92628D7814"),
                      IdCategory = "C4",
                      ProductName = "Chuột máy tính Logitech G Pro Wireless Gaming (Đen)",
                      ImageProduct = "https://lh3.googleusercontent.com/0-E5Fo9SKhAFknEetUN64y0NcMuZ4ciM5tgTN0KoU1Z5Vc_5HPvVGcF34vVVtBrdUYOOOKFdZ6m6zQ5xXoE=w500-rw",
                      OriginalPrice = 2549000,
                      Specifications = "- CPU: Apple M1;Màn hình: 13.3 IPS (2560 x 1600);RAM: 8GB Onboard LPDDR4 3733MHz; Đồ họa:;Lưu trữ: 256GB SSD /;Hệ điều hành: macOS;Pin liền;Khối lượng: 1.3 kg",
                      Warranty = 12,
                      Quantity = 3,
                      Rating = Enum.Rate.fiveStar
                  },
                  new Product
                  {
                      idproduct = new Guid("DC873C87-26F8-408A-AC82-D1D36B3AF7EC"),
                      IdCategory = "C2",
                      ProductName = "Máy tính để bàn - PC Acer AS XC-885 DT.BAQSV.010 (i5-8400/4GB/1TB HDD/GT 730/Win10)",
                      ImageProduct = "https://img1.phongvu.vn/media/catalog/product/1/_/1_38_31.jpg",
                      OriginalPrice = 11590000,
                      Specifications = "CPU: Intel Core i5-8400 ( 2.8 GHz - 4.0 GHz / 9MB / 6 nhân, 6 luồng );RAM: 1 x 4GB DDR4 2666MHz;Đồ họa: Intel UHD Graphics 630 / GeForce GT 730 2GB;Lưu trữ: 1TB HDD 7200RPM;Tặng kèm chuột; bàn phím",
                      Warranty = 12,
                      Quantity = 3,
                      Rating = Enum.Rate.fiveStar
                  }


                ) ;
        }
    }
}
