using HerosLib;
using System.Text.RegularExpressions;
namespace HerosUI.Menus
{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>
    public class MainMenu:IMenu
    {
        public  void Start(){
            do{
                System.Console.WriteLine("Welcome Friend! What would you like to do today?");
                //Options
                System.Console.WriteLine("[0] Create a hero");
            } while (!System.Console.ReadLine().Equals("0"));
            Hero newHero = GetHeroDetails();
            System.Console.WriteLine($"Hero {newHero.Name} was created with a superpower of {Hero.superPowers.Pop()}");

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