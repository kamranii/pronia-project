using System;
namespace ProniaBE.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Photo { get; set; }


		public virtual ICollection<Comment> Comments { get; set; }
		public Customer()
		{
		}
	}
}

