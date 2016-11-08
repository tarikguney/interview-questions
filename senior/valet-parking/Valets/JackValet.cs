using ConsoleApplication.Cars;
using ConsoleApplication.ParkingLots;
using System;
namespace ConsoleApplication.Valets{
    public class JackValet:IValet{
        public string Name{get{return "Jack";}}

        public void ParkCar(ICar car, IParkingLot parkingLot){
            var parkingSpaces = parkingLot.GetParkingSpaces();
            var randomSpaceGenerator = new Random();
            bool spaceFound = false;
            while(!spaceFound)
            {
                var randomSpace = randomSpaceGenerator.Next(parkingSpaces.Length-1);
                if(parkingSpaces[randomSpace] == null)
                {
                    spaceFound = true;
                    parkingSpaces[randomSpace] = car;
                }
            }
        }
    }
}