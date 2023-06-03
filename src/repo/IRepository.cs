using parking_system.Model;
using System.Collections.Generic;

namespace parking_system.Repository
{
    public interface IRepository
    {
        Dictionary<int, Vehicle> CreateNewParkingLot(int numberOfSlots);
        void Park(Dictionary<int, Vehicle> parkingLot, string plateNumber, string color, string type);
        void Leave(Dictionary<int, Vehicle> parkingLot, int slotNumber);
        void CheckStatus(Dictionary<int, Vehicle> parkingLot);
        void CountEmptyLot(Dictionary<int, Vehicle> parkingLot);
        void CountOccupiedLot(Dictionary<int, Vehicle> parkingLot);
        void CountByType(Dictionary<int, Vehicle> parkingLot, string type);
        void CountByOddPlate(Dictionary<int, Vehicle> parkingLot);
        void CountByEvenPlate(Dictionary<int, Vehicle> parkingLot);
        void CountByColor(Dictionary<int, Vehicle> parkingLot, string color);
        void SearchByColor(Dictionary<int, Vehicle> parkingLot, string color);
        void SearchByPlate(Dictionary<int, Vehicle> parkingLot, string plate);
    }
}