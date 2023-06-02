using System;
using Microsoft.EntityFrameworkCore;
using ProniaBE.Data;
using ProniaBE.Models;

namespace ProniaBE.Services.Implementations
{
	public class CustomerService
	{
		private readonly ApplicationDbContext _context;
		public CustomerService(ApplicationDbContext context)
		{
			_context = context;
		}

		//get customers with comments
		public async Task<IEnumerable<Customer>> GetCustomersWithComments()
		{
			return await _context.Customers.Where(c => c.Comments != null).Include(c => c.Comments).ToListAsync();
		}
	}
}

