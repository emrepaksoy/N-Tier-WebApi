using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {

        private readonly ISuperHeroService _superHeroService;
        public SuperHeroesController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_superHeroService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var o = _superHeroService.GetById(id);
            if (o == null)
                return BadRequest("not found");
            return Ok(o);
        }

        [HttpPost]
        public IActionResult Add(SuperHero superHero)
        {
            _superHeroService.Add(superHero);
            return Ok("Added");
        }

        [HttpPut]

        public IActionResult UpdateHero(SuperHero request)
        {
            var dbHero = _superHeroService.GetById(request.Id);
            if (dbHero == null)
                return BadRequest("not found");

            dbHero.Name = request.Name;
            dbHero.FirstName = request.FirstName;
            dbHero.LastName = request.LastName;
            dbHero.Place = request.Place;

            _superHeroService.Update(dbHero);
            return Ok(_superHeroService.GetById(dbHero.Id));
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteHero(int id)
        {
            var dbHero = _superHeroService.GetById(id);
            if (dbHero == null)
                return BadRequest("hero not found");

            _superHeroService.Delete(dbHero);
            return Ok("Hero deleted");
        }



    }
}
