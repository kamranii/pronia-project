using System;
using Microsoft.EntityFrameworkCore;
using ProniaBE.Models;

namespace ProniaBE.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions options)
			:base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<ProductTag> ProductTags { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.CreationDate)
                .HasDefaultValueSql("GetUtcDate()");
            modelBuilder.Entity<Post>()
               .Property(p => p.CreationDate)
               .HasDefaultValueSql("GetUtcDate()");
        }
    }
}

