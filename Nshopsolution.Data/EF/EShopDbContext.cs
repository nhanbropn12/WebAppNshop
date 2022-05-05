using Microsoft.EntityFrameworkCore;
using Nshopsolution.Data.Configurations;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext( DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
