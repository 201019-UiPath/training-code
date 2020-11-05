using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HerosDB;

namespace HerosWeb.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroRepo _repo;
        public SuperHeroController(ISuperHeroRepo repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> GetHeros()
        {
            var superHeros = await _repo.GetAllHeroesAsync();
            return View(superHeros);
        }
        public IActionResult GetHerosByName(string name)
        {
            var superhero=_repo.GetHeroByName(name);
            return View(superhero);
        }

    }
}
