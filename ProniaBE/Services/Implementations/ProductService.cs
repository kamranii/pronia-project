using System;
using Microsoft.EntityFrameworkCore;
using ProniaBE.Data;
using ProniaBE.Models;
using ProniaBE.Services.Interfaces;

namespace ProniaBE.Services
{
	public class ProductService: IProductService
	{
		private readonly ApplicationDbContext _context;
		public ProductService(ApplicationDbContext context)
		{
			_context = context;
		}

		//get all products

		public async Task<IEnumerable<Product>> GetAllProducts()
		{
			return await _context.Products.Include(p => p.Images).ToListAsync();
        }

		//get products
		public async Task<Dictionary<string, IEnumerable<Product>>> GetProductsDictionary()
		{
            Dictionary<string, IEnumerable<Product>> products = new Dictionary<string, IEnumerable<Product>>();
			var featured = await _context.Products.Where(p => p.Price >= 10).Include(p => p.Images).ToListAsync();
			products.Add("featured", featured);

			var bestseller = await _context.Products.OrderByDescending(p => p.TotalSaleAmount).Include(p => p.Images).Take(4).ToListAsync();
			products.Add("bestseller", bestseller);

			var latest = await _context.Products.OrderBy(p => p.CreationDate).Include(p => p.Images).Take(4).ToListAsync();
            products.Add("latest", latest);

			return products;
        }
	}
}

