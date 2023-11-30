using System.Collections.Generic;
using Тумаков_11лаб.BankClasses;

namespace Тумаков_11лаб.Classes
{
    public class Creator
    {
        private static Dictionary<int, Building> buildings = new Dictionary<int, Building>();

        private Creator() { } 

        public static Building CreateBuilding(int buildingNumber, string buildingName)
        {
            Building building = new Building(buildingNumber, buildingName);
            buildings.Add(buildingNumber, building);
            return building;
        }

        public static void RemoveBuilding(int buildingNumber)
        {
            buildings.Remove(buildingNumber);
        }
    }
}
