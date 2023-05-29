using System;
namespace ProniaBE.Models
{
	public class Image
	{
		public int Id { get; set; }
		public string Path { get; set; }
		public int ProductId { get; set; }
		public bool IsCover { get; set; }

		public virtual Product Product { get; set; }
		public Image()
		{
		}
	}
}

