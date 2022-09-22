using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SuperHeroManager : ISuperHeroService
    {
        private readonly ISuperHeroDAL _shrepo;
        public SuperHeroManager(ISuperHeroDAL shrepo)
        {
            _shrepo = shrepo;
        }

        public SuperHero GetById(int id)
        {
            return _shrepo.GetById(id);
        }

        public List<SuperHero> GetAll()
        {
            return _shrepo.GetAll();
        }

        public void Update(SuperHero superHero)
        {
            _shrepo.Update(superHero);
        }

        public void Add(SuperHero superHero)
        {
            _shrepo.Insert(superHero);
        }

        public void Delete(SuperHero superHero)
        {
           _shrepo.Delete(superHero);
        }
    }
}
