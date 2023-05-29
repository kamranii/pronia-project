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

		DbSet<Product> Products { get; set; }
		DbSet<Category> Categories { get; set; }
		DbSet<Image> Images { get; set; }
		DbSet<Tag> Tags { get; set; }
		DbSet<ProductTag> ProductTags { get; set; }
	}
}

