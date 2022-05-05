using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Configurations
{
    class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(x => x.Idcomment);
            builder.HasOne(x => x.Account).WithMany(x => x.Comments).HasForeignKey(x=>x.Iduser);
        }
    }
}
