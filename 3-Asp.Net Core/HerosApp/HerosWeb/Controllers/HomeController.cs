﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HerosWeb.Models;

namespace HerosWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id=0, string name="Avengers")// default parameters
        {
            //SuperHero hero = new SuperHero() { Id = 1, alias = "Thor", name = "Thor" };
            //ViewData["SuperHeroName"] = hero;
            //ViewBag.SuperHeroName = hero;
            //return View(hero);
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }
        [HttpGet]
        [Route("{Controller=Home}")]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
