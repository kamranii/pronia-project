﻿using System;
using ProniaBE.Models;

namespace ProniaBE.Services.Interfaces
{
	public interface ILoginService
	{
		public Task<User> Authenticate(UserLogin userLogin);
	}
}

