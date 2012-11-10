using MVCBoilerplate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBoilerplate.Repositories
{
    public class SqlNewsDbContext : DbContext
    {
        public SqlNewsDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        public DbSet<News> News { get; set; }
    }
}