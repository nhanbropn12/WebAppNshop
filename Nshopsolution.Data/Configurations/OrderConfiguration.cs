using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nshopsolution.Data.Entities;
using Nshopsolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Configurations
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.OrderId);
            //khoa ngoai
            /* builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.IdCategory);*/
            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
            builder.Property(x => x.CreateDay).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.status).HasDefaultValue(Status.Processing);
           
        }
    }
}
