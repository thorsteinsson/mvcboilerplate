using MVCBoilerplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBoilerplate.Repositories
{
    public class SqlNewsRepository : INewsRepository, IDisposable
    {
        SqlNewsDbContext context;

        public SqlNewsRepository(string nameOrConnectionString)
        {
            context = new SqlNewsDbContext(nameOrConnectionString);
        }

        private IQueryable<News> GetNewsOrderedByDateDescending()
        {
            return context.News.OrderByDescending(x => x.Date);
        }

        public List<News> GetNews()
        {
            return GetNewsOrderedByDateDescending().ToList();
        }

        public News GetLatest()
        {
            return GetNewsOrderedByDateDescending().FirstOrDefault();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}