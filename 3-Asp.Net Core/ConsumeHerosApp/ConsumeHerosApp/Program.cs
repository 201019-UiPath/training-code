using ConsumeHerosApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace ConsumeHerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllHeros();
        }

        public static void GetAllHeros()
        {
            string url = "https://localhost:44356/superhero/Get";
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response=client.GetAsync("");
                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask=result.Content.ReadAsAsync<SuperHero[]>();
                    readTask.Wait();

                    var superHeros=readTask.Result;
                    foreach (var superhero in superHeros)
                    {
                        Console.WriteLine($"{superhero.Id} {superhero.Alias}");
                    }
                }
            }
        }
    }
}
