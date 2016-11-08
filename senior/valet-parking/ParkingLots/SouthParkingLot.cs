using ConsoleApplication.Cars;

namespace ConsoleApplication.ParkingLots{
    public class SouthParkingLot:IParkingLot{
        private ICar[] _parkingSpaces;
        public SouthParkingLot ()
        {
           _parkingSpaces = new ICar[5];
        }

        public ICar[] GetParkingSpaces()
        {
            return _parkingSpaces;
        }
    }
}