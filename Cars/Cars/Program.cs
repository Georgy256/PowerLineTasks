using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar car1 = new PassengerCar(VehicleType.Motorbike, 5, 50, 100);
            car1.PassengerAmount = 4;
            Console.WriteLine(car1.GetReimainingDistance());
            Console.WriteLine(car1.GetPowerReserve());
            Console.WriteLine(car1.GetDistanceTime(500,50));
        }
    }
}
