using parking_system.Model;
using parking_system.Repository;
using parking_system.Util;
using System;
using System.Collections.Generic;

namespace parking_system.Service
{
    public class Service : IService
    {
        private Repository.Repository repository = new Repository.Repository();
        private Util.Validation util = new Util.Validation();

        public Dictionary<int, Vehicle> CreateNewParkingLot(int numberOfSlots)
        {
            return repository.CreateNewParkingLot(numberOfSlots);
        }

        public void Park(Dictionary<int, Vehicle> parkingLot, string plateNumber, string color, string type)
        {
            if (string.IsNullOrEmpty(plateNumber) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(type))
            {
                Console.WriteLine("Invalid data. Please provide complete vehicle data\n");
                return;
            }
            if (!string.Equals(type, "Mobil", StringComparison.OrdinalIgnoreCase) && !string.Equals(type, "Motor", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid type\n");
                return;
            }
            bool isPlateNumValid = util.ValidatePlateNumber(plateNumber);
            if (!isPlateNumValid)
            {
                Console.WriteLine("Invalid plate number\n");
                return;
            }
            repository.Park(parkingLot, plateNumber, color, type);
        }

        public void Leave(Dictionary<int, Vehicle> parkingLot, string slotNumberString)
        {
            if (!int.TryParse(slotNumberString, out int slotNumber) || slotNumber <= 0)
            {
                Console.WriteLine("Invalid number of slots. Please provide a positive integer\n");
                return;
            }
            repository.Leave(parkingLot, slotNumber);
        }

        public void CheckStatus(Dictionary<int, Vehicle> parkingLot)
        {
            repository.CheckStatus(parkingLot);
        }
        
        public void CountEmptyLot(Dictionary<int, Vehicle> parkingLot)
        {
           repository.CountEmptyLot(parkingLot);
        }
        
        public void CountOccupiedLot(Dictionary<int, Vehicle> parkingLot)
        {
            repository.CountOccupiedLot(parkingLot);
        }

        public void CountByType(Dictionary<int, Vehicle> parkingLot, string type)
        {
            if (!string.Equals(type, "Mobil", StringComparison.OrdinalIgnoreCase) && !string.Equals(type, "Motor", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid type\n");
                return;
            }
            repository.CountByType(parkingLot, type);
        }

        public void CountByOddPlate(Dictionary<int, Vehicle> parkingLot)
        {
            repository.CountByOddPlate(parkingLot);
        }

        public void CountByEvenPlate(Dictionary<int, Vehicle> parkingLot)
        {
            repository.CountByEvenPlate(parkingLot);
        }

        public void CountByColor(Dictionary<int, Vehicle> parkingLot, string color)
        {
            repository.CountByColor(parkingLot, color);
        }

        public void SearchByColor(Dictionary<int, Vehicle> parkingLot, string color)
        {
            repository.SearchByColor(parkingLot, color);
        }

        public void SearchByPlate(Dictionary<int, Vehicle> parkingLot, string plate)
        {
            bool isPlateNumValid = util.ValidatePlateNumber(plate);
            if (!isPlateNumValid)
            {
                Console.WriteLine("Invalid plate number\n");
                return;
            }
            repository.SearchByPlate(parkingLot, plate);
        }
    }
}