using System;
using Тумаков_11лаб.BankClasses;
using Тумаков_11лаб.Classes;

namespace Тумаков_11лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дз 11.1 - создать класс Creator,добавить фабричные методы CreateBuild,для здания использовать хеш-табл.\n");
            Building building1 = Creator.CreateBuilding(1, "Построение A");
            Building building2 = Creator.CreateBuilding(2, "Построение B");

            Console.WriteLine($"Построенное здание {building1.BuildingNumber}: {building1.BuildingName}");
            Console.WriteLine($"Построенное здание {building2.BuildingNumber}: {building2.BuildingName}");

            Creator.RemoveBuilding(1);
            Console.WriteLine("Построение 1 удалено из хэш-таблицы");
 
        }
    }
}
