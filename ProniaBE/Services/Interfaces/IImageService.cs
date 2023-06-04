using System;
using ProniaBE.Models;

namespace ProniaBE.Services.Interfaces
{
	public interface IImageService
	{
        public Task<IEnumerable<Image>> GetAllImages();
        public Task<IEnumerable<Image>> GetBrandImages();
    }
}

