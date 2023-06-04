using System;
using ProniaBE.Models;

namespace ProniaBE.Services.Interfaces
{
	public interface IPostService
	{
        public Task<IEnumerable<Post>> GetLatestPosts();

    }
}

