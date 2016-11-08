using System;
using System.Collections.Generic;
using ConsoleApplication.Cars;
using ConsoleApplication.ParkingLots;
using ConsoleApplication.Valets;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carQueue = new Queue<string>(new string[]{"Mazda","Toyota","Mercedes","BMW"});
            IValet jackValet = new JackValet();
            IValet michaelValet = new MichealValet();

            IParkingLot southParkingLot = new SouthParkingLot();
            IParkingLot northParkingLot = new NorthParkingLot();

            jackValet.ParkCar(CarFactory.GetCar("Mazda"), southParkingLot);
            michaelValet.ParkCar(CarFactory.GetCar("Toyota"), southParkingLot);

            jackValet.ParkCar(CarFactory.GetCar("Mercedes"), northParkingLot);
            michaelValet.ParkCar(CarFactory.GetCar("BMW"), northParkingLot);

            // Writing the parking lots to the output
            Console.WriteLine("South Parking Lot");
            Console.WriteLine("------------------");
            PrintParkingSpaceStatus(southParkingLot.GetParkingSpaces());
            
            Console.WriteLine("\nNorth Parking Lot");
            Console.WriteLine("--------------------");
            PrintParkingSpaceStatus(northParkingLot.GetParkingSpaces());
        }

        private static void PrintParkingSpaceStatus(ICar[] parkingLotSpaces){
            for(var i = 0; i < parkingLotSpaces.Length; i++){
                Console.WriteLine("Parking Space: " + i);
                Console.WriteLine("Car Name: " + (parkingLotSpaces[i] == null ? "Empty" : parkingLotSpaces[i].Name));
            }
        }
    }
}
