using Internet_Tech_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_Tech_1.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Vacancies> Vacancies { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
