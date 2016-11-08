using ConsoleApplication.Cars;

namespace ConsoleApplication.ParkingLots{
    public class NorthParkingLot: IParkingLot{
        private ICar[] _parkingSpaces;
        public NorthParkingLot ()
        {
          _parkingSpaces = new ICar[7];
        }

        public ICar[] GetParkingSpaces(){
            return _parkingSpaces;
        }
    }
}