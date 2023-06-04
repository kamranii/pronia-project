using System;
using ProniaBE.Models;

namespace ProniaBE.Services.Interfaces
{
	public interface IProductService
	{
        public Task<IEnumerable<Product>> GetAllProducts();
        public Task<Dictionary<string, IEnumerable<Product>>> GetProductsDictionary();

    }
}

