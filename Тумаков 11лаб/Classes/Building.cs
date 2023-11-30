
namespace Тумаков_11лаб.BankClasses
{
    public class Building
    {
        public int BuildingNumber { get; }
        public string BuildingName { get; }

        internal Building(int buildingNumber, string buildingName)
        {
            BuildingNumber = buildingNumber;
            BuildingName = buildingName;
        }
    }
}
