using System;
using ProniaBE.Models;

namespace ProniaBE.Services.Interfaces
{
	public interface IBrandService
	{
        public Task<IEnumerable<Brand>> GetBestBrands();

    }
}

