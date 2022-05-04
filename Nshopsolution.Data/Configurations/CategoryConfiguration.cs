using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //tên bảng
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            //bắc buộc nhập
            builder.Property(x => x.IsShowOnHome).HasDefaultValue(1);
            builder.Property(x => x.IsShowOnHome).IsRequired(true);
        }
    }
}
