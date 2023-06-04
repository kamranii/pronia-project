using System;
using ProniaBE.Models;

namespace ProniaBE.Services.Interfaces
{
	public interface ICustomerService
	{
        public Task<IEnumerable<Customer>> GetCustomersWithComments();

    }
}

