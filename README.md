# Parking System

[![made-with-.Net](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/) [![made-with-C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp) [![made-for-VSCode](https://img.shields.io/badge/VSCode-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)](https://code.visualstudio.com/)

## Table of contents
* [General Information](#general-information)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
    * [Creating a new parking lot](#creating-a-new-parking-lot)
    * [Parking a vehicle](#parking-a-vehicle)
    * [Leaving Parking Slot](#leaving-parking-slot)
    * [Checking Parking Lot Status](#checking-parking-lot-status)
    * [Checking the Number of Empty Parking Lots](#checking-the-number-of-empty-parking-lots)
    * [Checking the Number of Occupied Parking Lots](#checking-the-number-of-occupied-parking-lots)
    * [Checking the Number of Vehicles by Type](#checking-the-number-ofvehicles-by-type)
    * [Retrieving Registration Numbers for Vehicles with Odd License Plates](#retrieving-registration-numbers-for-vehicles-with-odd-license-plates)
    * [Retrieving Registration Numbers for Vehicles with Even License Plates](#retrieving-registration-numbers-for-vehicles-with-even-license-plates)
    * [Retrieving Registration Numbers for Vehicles with a Specific Color](#retrieving-registration-numbers-for-vehicles-with-a-specific-color)
    * [Retrieving Slot Numbers for Vehicles with a Specific Color](#retrieving-slot-numbers-for-vehicles-with-a-specific-color)
    * [Retrieving Slot Number for a Vehicle with a Specific Registration Number](#retrieving-slot-number-for-a-vehicle-with-a-specific-registration-number)
    * [Exiting the Application](#exiting-the-application)

## General Information
The Parking system is a console-based application that manages the occupancy of available parking lots.

## Technologies
This project is built using the following technologies:

- .NET 5.0 Framework
- C#
- Visual Studio Code (IDE)

## Setup
To run this project locally, follow these steps:

1. Clone the repository or download the source code.
```
git clone https://github.com/febriansr/parking-system
```
2. Go to the repository.
```
cd parking-system
```
3. Run the project.
```
dotnet run
```

Make sure you have the .NET Framework installed on your machine before running the project.

## Features

### Creating a new parking lot 
To create a parking lot, use the following command:
```
$ create_parking_lot <number_of_slots>
```
Replace `<number_of_slots>` with the desired number of parking slots as an integer. Make sure to provide a space between the command and the integer value.

For example, to create a parking lot with 10 slots, use the command:
```
$ create_parking_lot 10
Created a parking lot with 10 slots
```

### Parking a vehicle
To park a vehicle to the lot, use the following command:
```
$ park <plate_number> <color> <type_of_vehicle>
```
Replace `<plate_number>` with the vehicle's license plate number, `<color>` with the color of the vehicle, and `<type_of_vehicle>` with the type of vehicle ('Mobil' or 'Motor' only). Make sure to provide spaces between each parameter.

For example, to park a vehicle with the license plate number "B-1234-XYZ", color "Putih", and type "Mobil", use the command:
```
$ park B-1234-XYZ Putih Mobil
Allocated slot number: 1
```

### Leaving Parking Slot
To leave a parking slot, use the following command:
```
$ leave <parking_slot_number>
```
Replace `<parking_slot_number>` with the number of the parking lot that you want to leave. The parking lot number should be an integer value.

For example, to leave parking lot number 1, use the command:
```
$ leave 1
Slot number 1 is free
```

### Checking Parking Lot Status

To check the status of the parking lot, use the following command:
```
$ status
```
This command will display the current occupancy and the vehicle information that occupied the lot.

### Checking the Number of Empty Parking Lots 
To determine the number of empty parking lots, use the following command:

```
$ number_of_empty_lots
```

The output will display the total count of available empty parking lots.

Please note that this command does not consider the individual parking lot numbers, but rather gives you the aggregate count of empty parking lots.

### Checking the Number of Occupied Parking Lots 
To determine the number of occupied parking lots, use the following command:

```
$ number_of_occupied_lots
```
The output will display the total count of currently occupied parking lots.

Please note that this command does not provide specific information about individual parking lot numbers, but rather gives you the aggregate count of occupied parking lots.

### Checking the Number of Vehicles by Type 

To determine the number of vehicles of a specific type occupying the parking lot, use the following command:
```
$ type_of_vehicles <type_of_vehicle>
```

Replace `<type_of_vehicle>` with the specific type of vehicle you want to count. You can only use "Motor" or "Mobil".



### Retrieving Registration Numbers for Vehicles with Odd License Plates 

To retrieve a list of vehicles with odd-numbered license plates, use the following command:
```
$ registration_numbers_for_vehicles_with_odd_plate
```

This command will provide you with a list of registration numbers for vehicles that have license plates with odd numbers. The output will display a list of registration numbers for vehicles with odd-numbered license plates.

Please note that this command specifically filters vehicles based on the oddness of their license plate numbers.

### Retrieving Registration Numbers for Vehicles with Even License Plates 

To retrieve a list of vehicles with even-numbered license plates, use the following command:
```
$ registration_numbers_for_vehicles_with_even_plate
```

This command will provide you with a list of registration numbers for vehicles that have license plates with even numbers. The output will display a list of registration numbers for vehicles with even-numbered license plates.

Please note that this command specifically filters vehicles based on the evenness of their license plate numbers.

### Retrieving Registration Numbers for Vehicles with a Specific Color 

To retrieve a list of vehicles with a specific color, use the following command:
```
$ registration_numbers_for_vehicles_with_color <color>
```

Replace `<color>` with the specific color of the vehicles you want to filter. The output will display a list of registration numbers for vehicles that have the specified color.

Please note that this command filters vehicles based on their color and provides the registration numbers of the matching vehicles.

### Retrieving Slot Numbers for Vehicles with a Specific Color 

To retrieve the slot numbers for vehicles with a specific color, use the following command:
```
$ slot_numbers_for_vehicles_with_color <color>
```

Replace `<color>` with the specific color of the vehicles you want to filter. The output will display the slot numbers where vehicles with the specified color are parked.

Please note that this command filters vehicles based on their color and provides the slot numbers of the matching vehicles.


### Retrieving Slot Number for a Vehicle with a Specific Registration Number 

To retrieve the slot number for a vehicle with a specific registration number, use the following command:
```
$ slot_number_for_registration_number <plate_number>
```

Replace `<plate_number>` with the specific registration number of the vehicle you are interested in. The output will display the slot number where the vehicle with the specified registration number is parked.

Please note that this command searches for a specific registration number and provides the corresponding slot number.

### Exiting the Application

To exit or terminate the parking system application, use the following command:
```
$ exit
```

This command will close the application and return you to the command prompt or terminate the program.

Please note that any unsaved data or progress may be lost upon exiting the application, so make sure to save your work before using this command.
