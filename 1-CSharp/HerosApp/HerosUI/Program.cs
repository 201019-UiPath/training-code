﻿using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero obj=new Hero();
            #region default constructor
            /*Hero obj=new Hero();
            Console.WriteLine($"{obj.id} {obj.name}" );*/
            #endregion
            #region Parameterized constructor
            //Hero obj1=new Hero(2, "Narco");
           //Program obj1=new Program();
           //Console.WriteLine($"{obj1.id} {obj1.name}" );// cannot access the variable if they arenot public
            #endregion
            #region Access via Properties
            // Console.WriteLine(obj1.Id);// read property value
            // obj1.Id=3;
            // Console.Write($"New Id = {obj1.Id}");// write into a property
            #endregion
            #region Accessing  Arrays
           
            /*Console.Write("Please enter your heros id: ");
            obj.Id=Int32.Parse(Console.ReadLine());
            Console.Write("Please enter your Superhero name:");
            obj.Name=Console.ReadLine();
            Console.Write("Enter the first Power: ");
            obj.superPowers[0]
            Console.ReadLine();
            Console.Write($"{obj.Id} {obj.Name}  {obj.superPowers[0]}");*/
            // Jagged Arrays rows initializations
            /*obj.ja[0]=new int[2];// first column
            obj.ja[1]=new int[3];// second column
            obj.ja[2]=new int[1];// third column
            obj.ja[0][0]=10;
            obj.ja[1][2]=15;
            int[,,] td=new int[2,4,3];// 3-D arrays
            Console.WriteLine($"Dimension of the Array - {td.Rank}D");
            Console.WriteLine($"Number of elements in the Array - {td.Length}");
            Console.WriteLine(obj.ja.Rank);// rank is dimenssion of the array
            Console.WriteLine(obj.ja.Length);// elements of the arrays
            // loop through the jagged array
            foreach (var rows in obj.ja) //looping through all rows
            {
                //looping through all columns of every row
                for(int i=0; i<rows.Length;i++){
                    Console.Write($"{rows[i]} ");
                }
                Console.WriteLine();
            }*/
                        #endregion
            #region List<T>, Stack<T>
            //Console.WriteLine("Please enter the super power to be removed ");
            //string sp=Console.ReadLine();
            //Hero.superPowers.Remove(sp);
            // foreach(var superPower in Hero.GetSuperPowers()){
            //     Console.WriteLine(superPower);
            // }
            #endregion
            #region Dictionary<key, value>
            Console.WriteLine("Super Hero     Hideout");
            foreach(var superhero in Hero.hideOuts){
               // Console.WriteLine($"{superhero.Key}   {Hero.hideOuts[superhero.Key]}"); // old way
            //Console.WriteLine($"{superhero.Key} {superhero.Value}"); // new way of accessing key values
            }
            #endregion
        }
    }
}
