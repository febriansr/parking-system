using parking_system.Model;
using parking_system.Service;
using System;
using System.Collections.Generic;

namespace parking_system.Controller
{
    public class Controller {
        public void Menu()
        {
            var service = new parking_system.Service.Service();
            Console.WriteLine("Enter a command");
            string input = Console.ReadLine();
            Dictionary<int, Vehicle> parkingLot = null;
            while (!string.IsNullOrEmpty(input))
            {
                string[] commandParts = input.Split(' ');
                string command = commandParts[0].ToLower();

                switch (command) 
                {
                    case "create_parking_lot":
                        if (commandParts.Length != 2 || string.IsNullOrEmpty(commandParts[1]))
                        {
                            Console.WriteLine("Invalid input. Please provide a valid number of slots\n");
                            break;
                        }
                        if (!int.TryParse(commandParts[1], out int numberOfSlots) || numberOfSlots <= 0)
                        {
                            Console.WriteLine("Invalid number of slots. Please provide a positive integer\n");
                            return;
                        }
                        parkingLot = service.CreateNewParkingLot(numberOfSlots);
                        break;
                    case "park":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        if (commandParts.Length != 4)
                        {
                            Console.WriteLine("Invalid input. Please provide complete vehicle data\n");
                            break;
                        }
                        string plateNumber = commandParts[1];
                        string color = commandParts[2];
                        string type = commandParts[3];
                        service.Park(parkingLot, plateNumber, color, type);
                        break;
                    case "leave":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        if (commandParts.Length != 2 || string.IsNullOrEmpty(commandParts[1]))
                        {
                            Console.WriteLine("Invalid input. Please provide a slot number\n");
                            break;
                        }
                        service.Leave(parkingLot, commandParts[1]);
                        break;
                    case "status":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        service.CheckStatus(parkingLot);
                        break;
                    case "number_of_empty_lots":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        service.CountEmptyLot(parkingLot);
                        break;
                    case "number_of_occupied_lots":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        service.CountOccupiedLot(parkingLot);
                        break;
                    case "type_of_vehicles":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        if (commandParts.Length != 2 || string.IsNullOrEmpty(commandParts[1]))
                        {
                            Console.WriteLine("Invalid input. Please provide a type\n");
                            break;
                        }
                        string chosenType = commandParts[1];
                        service.CountByType(parkingLot, chosenType);
                        break;
                    case "registration_numbers_for_vehicles_with_odd_plate":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        service.CountByOddPlate(parkingLot);
                        break;
                    case "registration_numbers_for_vehicles_with_even_plate":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        service.CountByEvenPlate(parkingLot);
                        break;
                    case "registration_numbers_for_vehicles_with_color":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        if (commandParts.Length != 2 || string.IsNullOrEmpty(commandParts[1]))
                        {
                            Console.WriteLine("Invalid input. Please provide a color\n");
                            break;
                        }
                        string chosenColor = commandParts[1];
                        service.CountByColor(parkingLot, chosenColor);
                        break;
                    case "slot_numbers_for_vehicles_with_color":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        if (commandParts.Length != 2 || string.IsNullOrEmpty(commandParts[1]))
                        {
                            Console.WriteLine("Invalid input. Please provide a color\n");
                            break;
                        }
                        string chosenVehicleColor = commandParts[1];
                        service.SearchByColor(parkingLot, chosenVehicleColor);
                        break;
                    case "slot_number_for_registration_number":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("No parking lot\n");
                            break;
                        }
                        if (commandParts.Length != 2 || string.IsNullOrEmpty(commandParts[1]))
                        {
                            Console.WriteLine("Invalid input. Please provide a registration number\n");
                            break;
                        }
                        string chosenPlate = commandParts[1];
                        service.SearchByPlate(parkingLot, chosenPlate);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command\n");
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}

