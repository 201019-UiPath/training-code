using HerosLib;
using System.Text.RegularExpressions;
using HerosBL;
using System.Collections.Generic;
namespace HerosUI.Menus
{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>
    public class MainMenu:IMenu
    {
        HeroBL heroBL = new HeroBL();
        public  void Start(){
            string userInput; 
            do{
                System.Console.WriteLine("Welcome Friend! What would you like to do today?");
                //Options
                System.Console.WriteLine("[0] Create a hero \n[1] Get all heroes \n[2] Exit");
                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Hero newHero = GetHeroDetails();
                        heroBL.AddHero(newHero);
                        System.Console.WriteLine($"Hero {newHero.Name} was created with a superpower of {Hero.superPowers.Pop()}");
                        break;
                    case "1":
                        List<Hero> allheroes = heroBL.GetAllHeroes();
                        foreach(var hero in allheroes){
                            System.Console.WriteLine($"Hero {hero.Name}");
                        }
                        break;
                    case "2":
                        System.Console.WriteLine("Goodbye friend.");
                        break;
                    default:
                        System.Console.WriteLine("Invalid input! Please select a valid option!");
                        break;
                }
            } while (!userInput.Equals("2"));
        }

        public Hero GetHeroDetails()
        {
            Hero hero = new Hero();
            do{
                System.Console.WriteLine("Enter Hero Name: ");
                hero.Name = System.Console.ReadLine();
            }while(Regex.IsMatch(hero.Name, "[\\d]"));
            
            System.Console.WriteLine("Enter to add a super power to your hero: ");
            hero.AddSuperPower(System.Console.ReadLine());
            System.Console.WriteLine("Hero Created!"); // use logging software to log this
            //add step that pushes this hero's details to the BL
            return hero;
            
        }
    }
}