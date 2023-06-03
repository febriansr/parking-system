using parking_system.Model;
using System;
using System.Collections.Generic;

namespace parking_system.Repository
{
    public class Repository : IRepository
    {   
        public Dictionary<int, Vehicle> CreateNewParkingLot(int numberOfSlots)
        {
            Dictionary<int, Vehicle> parkingLot = new Dictionary<int, Vehicle>();
            for (int i = 1; i <= numberOfSlots; i++)
            {
                parkingLot.Add(i, null!);
            }
            Console.WriteLine($"Created a parking lot with {numberOfSlots} slots\n");
            return parkingLot;
        }

        public void Park(Dictionary<int, Vehicle> parkingLot, string plateNumber, string color, string type)
        {
            int availableSlot = -1;
            for (int i = 1; i <= parkingLot.Count; i++)
            {
                if (parkingLot[i] == null) 
                {
                    availableSlot = i;
                    break;
                }
            }

            if (availableSlot != -1)
            {
                Vehicle vehicle = new Vehicle(plateNumber, color, type);
                parkingLot[availableSlot] = vehicle;
                Console.WriteLine($"Allocated slot number: {availableSlot}\n");
            }
            else
            {
                Console.WriteLine("Sorry, parking lot is full\n");
            }
        }

        public void Leave(Dictionary<int, Vehicle> parkingLot, int slotNumber)
        {
            if (parkingLot.ContainsKey(slotNumber) && parkingLot[slotNumber] is not null)
            {
                parkingLot[slotNumber] = null;
                Console.WriteLine($"Slot number {slotNumber} is free\n");
            }
            else
            {
                Console.WriteLine("Invalid slot number\n");
            }
        }

        public void CheckStatus(Dictionary<int, Vehicle> parkingLot)
        {
            Console.WriteLine("Slot\tRegistration No\t\tType\tColor");
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value != null)
                {
                    int slotNumber = vehicle.Key;
                    Vehicle data = vehicle.Value;
                    Console.WriteLine($"{slotNumber}\t{data.PlateNumber}\t\t{data.Type}\t{data.Color}");
                }
            }
            Console.WriteLine("");
        }

        public void CountEmptyLot(Dictionary<int, Vehicle> parkingLot)
        {
            int count = 0;
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value == null)
                {
                    count = count+1;
                }
            }
            Console.WriteLine(count+"\n");
        }

        public void CountOccupiedLot(Dictionary<int, Vehicle> parkingLot)
        {
            int count = 0;
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value != null)
                {
                    count = count+1;
                }
            }
            Console.WriteLine(count+"\n");
        }
        
        public void CountByType(Dictionary<int, Vehicle> parkingLot, string type)
        {
            int count = 0;
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value != null)
                {
                    Vehicle data = vehicle.Value;
                    if (string.Equals(data.Type, type, StringComparison.OrdinalIgnoreCase)) 
                    {
                        count = count+1;
                    }
                }
            }
            Console.WriteLine(count+"\n");
        }

        public void CountByOddPlate(Dictionary<int, Vehicle> parkingLot)
        {
            List<string> oddPlateNumbers = new List<string>();
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value!= null)
                {
                    Vehicle data = vehicle.Value;
                    string[] plateParts = data.PlateNumber.Split('-');
                    int plateInt = int.Parse(plateParts[1]);
                    if (plateInt%2 != 0) 
                    {
                        oddPlateNumbers.Add(data.PlateNumber);
                    }
                }
            }
            if (oddPlateNumbers.Count <1)
            {
                Console.WriteLine("Not found");
            } else 
            {
                string result = string.Join(", ", oddPlateNumbers);
                Console.WriteLine(result+"\n");
            }
        }

        public void CountByEvenPlate(Dictionary<int, Vehicle> parkingLot)
        {
            List<string> evenPlateNumbers = new List<string>();
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value!= null)
                {
                    Vehicle data = vehicle.Value;
                    string[] plateParts = data.PlateNumber.Split('-');
                    int plateInt = int.Parse(plateParts[1]);
                    if (plateInt%2 == 0) 
                    {
                        evenPlateNumbers.Add(data.PlateNumber);
                    }
                }
            }
            if (evenPlateNumbers.Count <1)
            {
                Console.WriteLine("Not found");
            }
            string result = string.Join(", ", evenPlateNumbers);
            Console.WriteLine(result+"\n");
        }

        public void CountByColor(Dictionary<int, Vehicle> parkingLot, string color)
        {
            List<string> sortedVehicle = new List<string>();
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value!= null)
                {
                    Vehicle data = vehicle.Value;
                    if (string.Equals(data.Color, color, StringComparison.OrdinalIgnoreCase)) 
                    {
                        sortedVehicle.Add(data.PlateNumber);
                    }
                }
            }
            if (sortedVehicle.Count <1)
            {
                Console.WriteLine("Not found");
            }
            string result = string.Join(", ", sortedVehicle);
            Console.WriteLine(result+"\n");
        }

        public void SearchByColor(Dictionary<int, Vehicle> parkingLot, string color)
        {
            List<int> sortedVehicle = new List<int>();
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value != null)
                {
                    Vehicle data = vehicle.Value;
                    if (string.Equals(data.Color, color, StringComparison.OrdinalIgnoreCase)) 
                    {
                        sortedVehicle.Add(vehicle.Key);
                    }
                }
            }
            if (sortedVehicle.Count <1)
            {
                Console.WriteLine("Not found");
            }
            string result = string.Join(", ", sortedVehicle);
            Console.WriteLine(result+"\n");
        }

        public void SearchByPlate(Dictionary<int, Vehicle> parkingLot, string plate)
        {
            int result = -1;
            foreach (var vehicle in parkingLot)
            {
                if (vehicle.Value != null)
                {
                    Vehicle data = vehicle.Value;
                    if (string.Equals(data.PlateNumber, plate, StringComparison.OrdinalIgnoreCase)) 
                    {
                        result = vehicle.Key;
                    }
                }
            }
            if (result == -1)
            {
                Console.WriteLine("Not found");
            }
            Console.WriteLine(result+"\n");
        }
    }
}
