using System;
using System.Collections.Generic;

namespace HerosLib
{
    // internal partial class Hero{
    //     StreamReader streamReader;
    // }
   #region  old way of creating class members
   /*public class Hero// default modifier -> internal
    {
    // default modifier of members of a class is private
       int id;// value type => System.Int32
       public int Id{
           get{
               if(id>0)
                 return id;
           }
           set{
               id=value;
           }
       }
       public int Id{get;set;}// autonomous property
       string name;// reference type
        // Constructor - default
        public Hero(){
           // id=1;
            name="Bombasto";
        }
        // snippet ctor + double <tab> key
        public Hero(int id, string name)
        {
           /// this.id=id;
           Id=id;
            this.name=name;
        }
    }*/
   #endregion
   #region Mordern way of creating class member
   public partial class Hero{
       public int Id { get; set; }
       public string Name { get; set; }
       #region Arrays
       //public string[] superPowers=new string[10];// 1-D
       //jagged array
       //public int[][] ja=new int[3][];     
       #endregion
      // public static List<string> superPowers= new List<string>();
       public static Stack<string> superPowers= new Stack<string>();// LIFO
       public static Dictionary<string, string> hideOuts = new Dictionary<string, string>();
        public Hero()
        {
           superPowers.Push("Strength");
           superPowers.Push("Fly");
           superPowers.Push("Visibility");
           superPowers.Push("See through");

        //    hideOuts.Add("Thor","Asgard");
        //    hideOuts.Add("Batman","Batcave");
        //    hideOuts.Add("Superman","Fortress Solitude ");
        }
       public static IEnumerable<string> GetSuperPowers(){
          
           return superPowers;
       }
       public void RemoveSuperPower(){//string superPower){
           //if(superPowers.Contains(superPower)){
               //superPowers.Remove(superPower);
          // }    
          superPowers.Pop();
       }
       public void AddSuperPower(string superPower){
           if(superPower != null && superPower != ""){
               superPowers.Push(superPower);
           } else throw new ArgumentException("Super power shouldn't be null");
       }
   }
   #endregion
}
