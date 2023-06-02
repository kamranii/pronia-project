using System;
using ProniaBE.Enums;

namespace ProniaBE.Models
{
	public class IndexVM
	{
		public Dictionary<string, IEnumerable<Product>> ProductsByTabs { get; set; }
		public IEnumerable<Image> BannerImages { get; set; }
		public IEnumerable<Customer> Customers { get; set; }
		public IEnumerable<Brand> Brands { get; set; }
		public IEnumerable<Post> Posts { get; set; }
	}
}

