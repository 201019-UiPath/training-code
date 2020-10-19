//1.0 predefined namespace
using System;

//1.1 custom defined namespace
namespace helloWorld
{
    class Program
    {
        // execution starts here
                        //Commandline arguments
                        // vvv
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! "+DateTime.Now);
            string firstname, lastname;
            Console.WriteLine("Please enter your first name");
            firstname = Console.ReadLine();// takes user's input in string form
            Console.WriteLine("Please enter your last name"); 
            lastname = Console.ReadLine();
            //Console.WriteLine("Welcome "+firstname +" "+lastname);
            Console.WriteLine($"welcome {firstname}-{lastname}");
        }
    }
}
