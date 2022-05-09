using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Configurations
{
    class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
       

        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");
            builder.Property(x => x.Description).HasMaxLength(200);
        }
    }
}
