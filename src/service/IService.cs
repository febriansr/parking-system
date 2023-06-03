using parking_system.Model;
using parking_system.Repository;
using System;
using System.Collections.Generic;

namespace parking_system.Service 
{
    public interface IService 
    {
        Dictionary<int, Vehicle> CreateNewParkingLot(int numberOfSlotsString);
        void Park(Dictionary<int, Vehicle> parkingLot, string plateNumber, string color, string type);
        void Leave(Dictionary<int, Vehicle> parkingLot, string slotNumberString);
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