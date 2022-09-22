using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataContext:DbContext
    {


        public DataContext(DbContextOptions options) : base(options)
        {
        }



        protected DataContext()
        {
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
