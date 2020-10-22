using HerosLib;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HerosDB
{
    /// <summary>
    /// Data access interface for hero stuff
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Adds hero to data storage place
        /// </summary>
        /// <param name="hero"></param>
         void AddHeroAsync(Hero hero);
         /// <summary>
         /// Gets all heros from data storage place
         /// </summary>
         /// <returns></returns>
         Task<List<Hero>> GetAllHerosAsync();

    }
}