using ConsoleApplication.Cars;

namespace ConsoleApplication.ParkingLots
{
    public interface IParkingLot
    {
        ICar[] GetParkingSpaces();
    }
}