﻿using HerosDB.Entities;
using HerosDB;
using HerosDbWithADO;
namespace HeroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Data db=new Data();
            db.GetSuperPersonConnected();
            /*IMenu main = new MainMenu(new HeroContext(), new DBMapper());
            main.start();*/
        }

    }
}
