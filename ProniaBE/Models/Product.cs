using System;
using System.ComponentModel.DataAnnotations;

namespace ProniaBE.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Summary { get; set; }
		public string Variable { get; set; }
		public int AmountInStock { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }

		public virtual Category Category { get; set; }
		public virtual ICollection<ProductTag> ProductTags { get; set; }
		public virtual ICollection<Image> Images { get; set; }
	}
}

