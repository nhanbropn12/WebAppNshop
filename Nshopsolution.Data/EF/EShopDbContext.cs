using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nshopsolution.Data.Configurations;
using Nshopsolution.Data.Entities;
using Nshopsolution.Data.Extention;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.EF
{
    public class EShopDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public EShopDbContext()
        {

        }
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //configuration using fluent api
            //configuration identity
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            //configuration identity 2
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            //data seeding
            modelBuilder.seed();
        }

        

        public DbSet<Comment> Comments { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        /*public DbSet<Product> products { get; set; } đã config nên không cần thêm vào*/
        /*public DbSet<Product> Categories{ get; set; } đã config nên không cần thêm vào*/
    }
}
