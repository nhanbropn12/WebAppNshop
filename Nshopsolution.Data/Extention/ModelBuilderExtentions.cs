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
                );}
    }
}
