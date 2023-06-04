using System;
using Microsoft.EntityFrameworkCore;
using ProniaBE.Data;
using ProniaBE.Models;
using ProniaBE.Services.Interfaces;

namespace ProniaBE.Services.Implementations
{
	public class BrandService: IBrandService
	{
		private readonly ApplicationDbContext _context;
		public BrandService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Brand>> GetBestBrands()
		{
			return await _context.Brands.OrderByDescending(b => b.Rating).Take(5).ToListAsync();
		}
	}
}

