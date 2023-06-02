using System;
namespace ProniaBE.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public int CustomerId { get; set; }

		public Customer Customer { get; set; }
		public Comment()
		{
		}
	}
}

