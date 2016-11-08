using ConsoleApplication.Cars;
using ConsoleApplication.ParkingLots;

namespace ConsoleApplication.Valets{
    public class MichealValet:IValet{
        public string Name{get{return "Michael";}}
        public void ParkCar(ICar car, IParkingLot parkingLot)
        {
            var parkingSpaces = parkingLot.GetParkingSpaces();
            for(var i = 0; i < parkingSpaces.Length; i++){
                if(parkingSpaces[i] == null)
                {
                    parkingSpaces[i] = car;
                    break;
                }
            }
        }
    }
}