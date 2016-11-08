using ConsoleApplication.ParkingLots;
using ConsoleApplication.Cars;

namespace ConsoleApplication.Valets{
    public interface IValet
    {
        string Name{get;}
        void ParkCar(ICar car, IParkingLot parkingLot);
    }
}