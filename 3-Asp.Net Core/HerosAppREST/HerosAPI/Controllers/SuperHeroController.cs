﻿using HerosDB.Models;
using HerosLib;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HerosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly IHeroService _heroService;

        public SuperHeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet("get")]
        [Produces("application/json")]
        public IActionResult GetAllHeroes()
        {
            try
            {
                return Ok(_heroService.GetAllHeroes());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("get/{name}")]
        [Produces("application/json")]
        public IActionResult GetHeroByName(string name)
        {
            try
            {
                return Ok(_heroService.GetHeroByName(name));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult AddHero(SuperHero newSuperHero)
        {
            try
            {
                _heroService.AddHero(newSuperHero);
                return CreatedAtAction("AddHero", newSuperHero);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}