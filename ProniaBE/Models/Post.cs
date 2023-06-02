using System;
namespace ProniaBE.Models
{
	public class Post
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string CreationDate { get; set; }
		public string Content { get; set; }
		public string CoverPhoto { get; set; }
		public Post()
		{
		}
	}
}

