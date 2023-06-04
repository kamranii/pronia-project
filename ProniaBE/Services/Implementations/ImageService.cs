using System;
using Microsoft.EntityFrameworkCore;
using ProniaBE.Data;
using ProniaBE.Models;
using ProniaBE.Services.Interfaces;

namespace ProniaBE.Services.Implementations
{
	public class ImageService: IImageService
	{
		private readonly ApplicationDbContext _context;
		public ImageService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Image>> GetAllImages()
		{
			return await _context.Images.ToListAsync();
		}
		//get random images
		public async Task<IEnumerable<Image>> GetBrandImages()
		{
			int total = await _context.Images.CountAsync();
			int randomSkip = (new Random()).Next(1, total - 4);
			return await _context.Images.Skip(randomSkip).Take(4).ToListAsync();
		}
	}
}

