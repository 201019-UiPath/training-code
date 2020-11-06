using HerosDB.Models;
using System.Collections.Generic;

namespace HerosLib
{
    public interface IVillainService
    {
        void AddVillain(SuperVillain newVillain);
        List<SuperVillain> GetAllVillains();
        SuperVillain GetVillainByName();
    }
}