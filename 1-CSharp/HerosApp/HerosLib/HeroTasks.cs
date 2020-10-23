using System;
using System.Threading.Tasks;

namespace HerosLib
{
    public delegate void HeroDel(); 
    public class HeroTasks : IHeroOperations, IHeroSuperPowers
    {
        string path=@"C:\Revature\201019-Uta-UiPath\training-code\1-CSharp\SuperPowers.txt";
        public event HeroDel workDone;
        public async void DoWork(){
            Console.WriteLine("Work Started.....");
            await Task.Run(new Action(GetPowers));
            Console.WriteLine("Saving humanity is my work");
            Console.WriteLine("Work finished");
            OnWorkDone();
        }
        public void OnWorkDone(){
            if(workDone!=null){
                workDone();// raising the event 
            }
        }
        public void ManageLife(){
            Console.WriteLine("I have a cranky partner to manage");
        }
        public void GetPowers(){
            Console.WriteLine("Getting Powers");
            System.Threading.Thread.Sleep(2000);
            string superPower=System.IO.File.ReadAllText(path);
            Console.WriteLine($"Power obtained {superPower}");
        }
    }
}