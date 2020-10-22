using System;

namespace HerosLib
{
    public delegate void HeroDel(); 
    public class HeroTasks : IHeroOperations, IHeroSuperPowers
    {
        string path="../SuperPowers.txt";
        public void DoWork(){
            Console.WriteLine("Saving humanity is my work");
        }
        public void ManageLife(){
            Console.Write("I have a cranky partner to manage");
        }
        public void GetPowers(){
            string superPower=System.IO.File.ReadAllText(path);
            Console.WriteLine(superPower);
        }
    }
}