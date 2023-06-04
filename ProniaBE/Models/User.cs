using System;
using System.ComponentModel.DataAnnotations;

namespace ProniaBE.Models
{
	public class User
	{
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }

        public User()
		{

		}
	}
}

