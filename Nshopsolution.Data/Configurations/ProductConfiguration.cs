using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.idproduct);
            // KhoÁ PHỤ
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.IdCategory);
            builder.Property(x => x.discount).HasMaxLength(50).HasDefaultValue(0);
            
        }
    }
}
