using HerosLib;
using HerosDB;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HerosBL
{
    public class HeroBL
    {
        IRepository repo = new FileRepo();
        public void AddHero(Hero newHero){
            //You can add the business logic to check stuff
            //Like maybe, check if the hero name is unique, so you get all the other hero names and check it against this hero's name
            // Throw an exception or two
            repo.AddHeroAsync(newHero);
        }

        public List<Hero> GetAllHeroes()
        {
            Task<List<Hero>> getHeroes = repo.GetAllHerosAsync();
            return getHeroes.Result;
        }
    }
}