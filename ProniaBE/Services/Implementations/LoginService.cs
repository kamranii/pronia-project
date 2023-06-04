using System;
using ProniaBE.Models;
using ProniaBE.Services.Interfaces;

namespace ProniaBE.Services.Implementations
{
	public class LoginService: ILoginService
	{
		public LoginService()
		{
		}

        public Task<User> Authenticate(UserLogin login)
        {
            throw new NotImplementedException();
        }
    }
}

