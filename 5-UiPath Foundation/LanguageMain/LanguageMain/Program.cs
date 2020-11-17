using System;

namespace LanguageMain
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpLib.TestDemo testcsharp = new CSharpLib.TestDemo();
            testcsharp.GetFullName("Pushpinder","","Kaur");
            var resultsChsarp=testcsharp.LoadFile();
            foreach (var item in resultsChsarp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************");
            VbLib.TestDemo testVb = new VbLib.TestDemo();
            testVb.GetFullName("Marielle","C","Nolasco");
            var resultsVb=testVb.LoadFile();
            foreach (var item in resultsVb)
            {
                Console.WriteLine(item);
            }
        }
    }
}
