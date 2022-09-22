using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISuperHeroService
    {
        SuperHero GetById(int id);
        List<SuperHero> GetAll();
        void Add(SuperHero superHero);
        void Update(SuperHero superHero);

        void Delete(SuperHero superHero);
        
    }
}
