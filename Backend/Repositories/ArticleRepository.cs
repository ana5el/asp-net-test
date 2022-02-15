using System;
using Backend.Data;
using Backend.Models;

namespace Backend.Repositories
{
	public class ArticleRepository : GenericRepository<Article>, IArticleRepository
	{
		public ArticleRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}

