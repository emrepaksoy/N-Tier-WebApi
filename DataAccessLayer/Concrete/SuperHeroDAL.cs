using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class SuperHeroDAL : Repository<SuperHero>, ISuperHeroDAL
    {
        public SuperHeroDAL(DbContext context) : base(context)
        {
        }
    }
}
