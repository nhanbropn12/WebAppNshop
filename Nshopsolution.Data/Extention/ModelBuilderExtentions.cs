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
                 }


                 );
        }
    }
}
