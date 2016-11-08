using ConsoleApplication.Cars;
using System;

namespace ConsoleApplication
{
    public static class CarFactory
    {
        public static ICar GetCar(string carName){
            switch(carName.ToLower()){
                case "mazda":
                    return new Mazda();
                case "toyota":
                    return new Toyota();
                case "bmw":
                    return new BMW();
                case "mercedes":
                    return new Mercedes();
            }
            throw new ArgumentException("Unknown car type");
        }
    }
}