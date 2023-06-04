using System;
using System.ComponentModel.DataAnnotations;

namespace ProniaBE.Models
{
	public class UserLogin
	{
		[Required]
        public string Username { get; set; }
		[Required]
        public string Password { get; set; }

        public UserLogin()
		{
		}
	}
}

