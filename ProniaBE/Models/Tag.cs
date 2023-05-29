﻿using System;
namespace ProniaBE.Models
{
	public class Tag
	{
		public int Id { get; set; }
		public string Name { get; set; }


		public virtual ICollection<ProductTag> ProductTags { get; set; }
		public Tag()
		{
		}
	}
}

