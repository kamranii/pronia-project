using System;
using Microsoft.EntityFrameworkCore;
using ProniaBE.Data;
using ProniaBE.Models;
using ProniaBE.Services.Interfaces;

namespace ProniaBE.Services.Implementations
{
	public class PostService: IPostService
	{
		private readonly ApplicationDbContext _context;
		public PostService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Post>> GetLatestPosts()
		{
			return await _context.Posts.OrderBy(p => p.CreationDate).Take(3).ToListAsync();
		}
	}
}

