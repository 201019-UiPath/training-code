using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HerosDB;
using HerosWeb.Models;
using db=HerosDB.Models;

namespace HerosWeb.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroRepo _repo;
        private db.SuperHero hero= new db.SuperHero();
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
        /// <summary>
        /// This action return the form
        /// </summary>
        /// <returns></returns>
        public ViewResult AddHero()
        {
            return View();
        }
        /// <summary>
        /// This action will submit the form values recieved to the DB
        /// </summary>
        /// <param name="superHero"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                hero.Alias = superHero.Alias;
                hero.RealName = superHero.RealName;
                hero.HideOut = superHero.HideOut;
                _repo.AddAHeroAsync(hero);
                return RedirectToAction("GetHeros");
            }
            else
                return View();
        }

    }
}
