using System;
using Backend.Data;
using Backend.Models;

namespace Backend.Repositories
{
	public class ReceptionRepository : GenericRepository<Reception>, IReceptionRepository
	{
		public ReceptionRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}

