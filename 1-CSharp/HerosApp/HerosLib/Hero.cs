using System;

namespace HerosLib
{
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
   public class Hero{
       public int Id { get; set; }
       public string Name { get; set; }
       public string[] superPowers=new string[10];// 1-D
       //jagged array
       public int[][] ja=new int[3][];     
   }
   #endregion
}
